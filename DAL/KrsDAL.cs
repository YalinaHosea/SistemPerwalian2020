using System.Collections.Generic;
using SistemPerwalian2020.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemPerwalian2020.DAL;
using System;

namespace SistemPerwalian2020.DAL
{
    public class KrsDAL : IKrs
    {
        private IConfiguration _config;

        public KrsDAL(IConfiguration config)
        {
            _config = config;
        }
        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }
public string getAngkatan(string nim)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"select Angkatan from Mahasiswa where NIM='" + nim + "'";
                return conn.QueryFirstOrDefault<string>(sql);
            }
        }
        public Krs GetKrs(string nim)
        {
            Krs data = new Krs();
            var tgl = DateTime.Now.Year.ToString();
            var tglnow = DateTime.Now.Month;
            var angkatan = getAngkatan(nim);
            var semester= "";
            var sem = (Int32.Parse(tgl) - Int32.Parse(angkatan)) * 2;
            if(tglnow > 7) {
                sem += 1;
            }
            if (sem % 2 == 0)
            {
                semester = "Genap";
            }
            else
            {
                semester = "Ganjil";
            }
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Krs where Nim=" + nim + " and Semester='" + semester + "'";
                var krs = conn.QuerySingleOrDefault<Krs>(strSql);
                if (krs == null)
                {
                    var sql2 = @"insert into Krs (Nim, Semester) values(@nim, @semester)";
                    var param = new { nim = nim, semester = semester };
                    conn.Execute(sql2, param);

                    var sql3 = @"select * from Krs where Nim=" + nim + " and Semester='" + semester + "'";
                    krs = conn.QuerySingleOrDefault<Krs>(strSql);
                }
                data.Id_krs = krs.Id_krs;
                data.Nim = krs.Nim;
                data.Semester = krs.Semester;

                var sql1 = @"select m.Kode_matkul, m.Nama_makul, m.SKS from Detail_KRS d inner join Mata_Kuliah m on d.Kode_matkul=m.Kode_matkul where d.Id_krs=" + krs.Id_krs;
                var det = conn.Query<DetailKrs_ViewModel>(sql1);
                data.detail = det;
            }
            return data;
        }

        public IEnumerable<MataKuliah> GetMakul()
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql1 = @"select * from Mata_Kuliah ";
                return conn.Query<MataKuliah>(sql1);
            }
        }

        public void SaveKrs(IList<DetailKrs_ViewModel> det)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                foreach (var data in det)
                {
                    var sql1 = @"select * from Detail_Krs where Id_krs=" + data.Id_krs + " and Kode_matkul='" + data.Kode_Matkul + "'";
                    var data2 = conn.QuerySingleOrDefault<DetailKrs>(sql1);

                    if (data2 == null)
                    {
                        var sql = @"insert into Detail_Krs (Id_krs, Kode_matkul) values(@id, @kode)";
                        var param = new { id = data.Id_krs, kode = data.Kode_Matkul };
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

        public void DeleteMakul(int id, string kode)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"delete from Detail_Krs where Id_krs=" + id + " and Kode_matkul='" + kode + "'";
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
    }
}
