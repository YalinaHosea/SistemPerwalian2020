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
                var strSql = @"select * from Mahasiswa order by Nim";
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
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Mahasiswa where NIM=@Id";
                var param = new { Id = nim };
                return conn.QuerySingleOrDefault<Mahasiswa>(strSql, param);
            }
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
        public IEnumerable<MakulViewModel> GetMakul(string periode, string semester)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sqlkode = @"select Id_Krs from KRS where Periode='" + periode + "' and Semester='" + semester + "'";
                var kode = conn.QueryFirstOrDefault<int>(sqlkode);

                var sql1 = @"select g.id, m.Kode_matkul, m.Nama_makul, m.SKS, m.Harga, g.Grup, g.Jadwal, g.Sesi, g.Ruangan, d.Nama" +
                " from Grup_makul g inner join Mata_Kuliah m on g.Kode_matkul=m.Kode_matkul inner join Dosen d on g.Nik=d.Nik inner join Detail_KRS det on det.id_makul = g.id where det.Id_krs=" + kode;
                return conn.Query<MakulViewModel>(sql1);
            }
        }
        public string getAngkatan(string nim)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"select Angkatan from Mahasiswa where NIM='" + nim + "'";
                return conn.QueryFirstOrDefault<string>(sql);
            }
        }
        public TranskripViewModel GetNilai(string nim, string role, string state)
        {
            TranskripViewModel data = new TranskripViewModel();
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                IList<TranskripNilai> nilai;
                var strSql = @"select * from Transkrip_Nilai where NIM=" + nim;
                nilai = (IList<TranskripNilai>)conn.Query<TranskripNilai>(strSql);

                if (nilai.Count == 0)
                {
                    return null;
                }
                data.transkrip = nilai;

                var strSql2 = @"select * from Mahasiswa where NIM=" + nim;
                Mahasiswa mhs = new Mahasiswa();
                mhs = conn.QueryFirstOrDefault<Mahasiswa>(strSql2);
                data.mahasiswa = mhs;

                var strSql3 = @"select d.id_makul, d.Kode_detail, g.Kode_matkul, m.Nama_makul, m.SKS, g.Grup, d.Nilai, d.Bobot, d.Kualitas from Detail_Transkrip d inner join Grup_makul g on d.id_makul=g.id inner join Mata_Kuliah m on g.Kode_matkul=m.Kode_matkul";
                var detail = conn.Query<DetailTranskrip>(strSql3);
                data.detail = detail;
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

        public void CreateNilai(IList<DetailTranskrip> det, string periode, string semester, string nim)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var kode = "";
                var sql3 = @"select Kode_Transkrip from Transkrip_Nilai where Nim='" + nim + "' and Periode='" + periode + "' and Semester='" + semester + "'";
                kode = conn.QueryFirstOrDefault<string>(sql3);

                if (kode == null)
                {
                    var sqlupdate = @"insert into Transkrip_Nilai(Nim,Periode,Semester) values(@nim,@periode,@semester)";
                    var param1 = new { nim = nim, periode = periode, semester = semester };
                    conn.Execute(sqlupdate, param1);

                    var sql2 = @"select Kode_Transkrip from Transkrip_Nilai where Nim='" + nim + "' and Periode='" + periode + "' and Semester='" + semester + "'";
                    kode = conn.QueryFirstOrDefault<string>(sql2);
                }
                foreach (var data in det)
                {
                    var sks = getSKSbyKode(data.Kode_matkul);
                    var bobot = getBobot(data.Nilai);
                    var kualitas = sks * bobot;

                    var sqlcek = @"select Kode_detail from Detail_Transkrip where Kode_transkrip=" + kode + " and id_makul=" + data.id_makul;
                    var kodet = conn.QueryFirstOrDefault<string>(sqlcek);

                    if (kodet == null)
                    {
                        var sql = @"insert into Detail_Transkrip (Kode_transkrip, id_makul,Nilai,bobot,kualitas) values(@id, @kode,@nilai,@bobot,@kualitas)";
                        var param = new { id = kode, kode = data.id_makul, nilai = data.Nilai, bobot = bobot, kualitas = kualitas };
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
                        var sql = @"update Detail_Transkrip set Nilai=@nilai, bobot=@bobot, kualitas=@kualitas where Kode_detail=" + kodet;
                        var param = new { nilai = data.Nilai, bobot = bobot, kualitas = kualitas };
                        try
                        {
                            conn.Execute(sql, param);
                        }
                        catch (SqlException x)
                        {
                            throw new Exception($"error : {x.Message}");
                        }

                    }
                }
            }
        }
    }
}