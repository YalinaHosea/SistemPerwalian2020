using System.Collections.Generic;
using SistemPerwalian2020.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemPerwalian2020.DAL;
using System;

namespace SistemPerwalian2020.DAL
{
    public class MahasiswaDAL : IMahasiswa
    {
        private IConfiguration _config;

        public MahasiswaDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<Mahasiswa> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Mahasiswa order by Nama_mhs";
                return conn.Query<Mahasiswa>(strSql);
            }
        }
        public void DeleteMakul(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"delete from Detail_Transkrip where Kode_detail=" + id;
                try
                {
                    conn.Execute(sql);
                }
                catch (SqlException x)
                {
                    throw new Exception($"error : {x.Message}");
                }
            }
        }

        public Mahasiswa GetByNim(string nim)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Mahasiswa mhs)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Mahasiswa mhs)
        {
            throw new System.NotImplementedException();
        }

        public Mahasiswa Login(string Id, string Password)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Mahasiswa where NIM=@Id and Password=@Password";
                var param = new { Id = Id, Password = Password };
                return conn.QuerySingleOrDefault<Mahasiswa>(strSql, param);
            }
        }

        public TranskripViewModel GetNilai(string nim, string role)
        {
            TranskripViewModel data = new TranskripViewModel();
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                TranskripNilai nilai = new TranskripNilai();
                var strSql = @"select * from Transkrip_Nilai where NIM=" + nim;
                nilai = conn.QueryFirstOrDefault<TranskripNilai>(strSql);
                if (role == "superadmin" && nilai == null)
                {
                    var sql = @"insert into Transkrip_Nilai(Nim) values(@nim)";
                    var param = new { nim = nim };
                    conn.Execute(sql, param);

                    var sql2 = @"select * from Transkrip_Nilai where NIM=" + nim;
                    nilai = conn.QueryFirstOrDefault<TranskripNilai>(strSql);
                    data.transkrip = nilai;
                }
                else if(role == "superadmin" || role == "dosen" && nilai != null)
                {
                    data.transkrip = nilai;
                }
                // else
                // {
                //     return null;
                // }

                var strSql2 = @"select * from Mahasiswa where NIM=" + nim;
                Mahasiswa mhs = new Mahasiswa();
                mhs = conn.QueryFirstOrDefault<Mahasiswa>(strSql2);
                data.mahasiswa = mhs;

                var strSql3 = @"select d.Kode_detail, d.Kode_matkul, m.Nama_makul, m.SKS, d.Nilai, d.Bobot, d.Kualitas from Detail_Transkrip d inner join Mata_Kuliah m on d.Kode_matkul=m.Kode_matkul where d.Kode_transkrip=" + nilai.Kode_Transkrip;
                var detail = conn.Query<DetailTranskrip>(strSql3);
                data.detail = detail;
                //return conn.Query<Mahasiswa>(strSql);
                return data;
            }
        }

        public int getSKSbyKode(string kode)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"select SKS from Mata_Kuliah where Kode_matkul='" + kode + "'";
                return conn.QueryFirstOrDefault<int>(sql);
            }
        }

        public float getBobot(string nilai)
        {
            float bobot = 0;
            if (nilai == "A")
            {
                bobot = 4.0f;
            }
            else if (nilai == "A-")
            {
                bobot = 3.7f;
            }
            else if (nilai == "B+")
            {
                bobot = 3.3f;
            }
            else if (nilai == "B")
            {
                bobot = 3.0f;
            }
            else if (nilai == "B-")
            {
                bobot = 2.7f;
            }
            else if (nilai == "C+")
            {
                bobot = 2.4f;
            }
            else if (nilai == "C")
            {
                bobot = 2.1f;
            }
            else if (nilai == "C-")
            {
                bobot = 1.8f;
            }
            else if (nilai == "D")
            {
                bobot = 1.5f;
            }
            else if (nilai == "E")
            {
                bobot = 1.2f;
            }
            else if (nilai == "F")
            {
                bobot = 0.0f;
            }
            return bobot;
        }

        public void CreateNilai(IList<DetailTranskrip> det)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                foreach(var data in det)
                {
                    var sql1 = @"select * from Detail_Transkrip where Kode_transkrip=" + data.Kode_transkrip + " and Kode_matkul='" + data.Kode_matkul + "'";
                    var data2 = conn.QuerySingleOrDefault<DetailTranskrip>(sql1);
                    var sks = getSKSbyKode(data.Kode_matkul);
                    var bobot = getBobot(data.Nilai);
                    var kualitas = sks * bobot;

                    if (data2 == null)
                    {
                        
                        var sql = @"insert into Detail_Transkrip (Kode_transkrip, Kode_matkul,Nilai,bobot,kualitas) values(@id, @kode,@nilai,@bobot,@kualitas)";
                        var param = new { id = data.Kode_transkrip, kode = data.Kode_matkul, nilai = data.Nilai, bobot = bobot, kualitas = kualitas};
                        try
                        {
                            conn.Execute(sql, param);
                        }
                        catch (SqlException x)
                        {
                            throw new Exception($"error : {x.Message}");
                        }
                    }
                    else
                    {
                        var sql2 = @"update Detail_Transkrip set Nilai='" + data.Nilai + "', bobot=@bobot, kualitas=@kualitas where Kode_transkrip=" + data.Kode_transkrip + " and Kode_matkul='" + data.Kode_matkul + "'";
                        var param = new { bobot = bobot, kualitas = kualitas };
                        try
                        {
                            conn.Execute(sql2, param);
                        }
                        catch (SqlException x)
                        {
                            throw new Exception($"error : {x.Message}");
                        };
                    }
                }
            }
        }
    }
}