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
        public Krs GetKrsforCreate(string nim, string periode, string semester)
        {
            Krs data = new Krs();

            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Krs where Nim='" + nim + "' and Periode='" + periode + "' and Semester='" + semester + "'";
                var krs = conn.QuerySingleOrDefault<Krs>(strSql);

                data.Id_krs = krs.Id_krs;
                data.Nim = krs.Nim;
                data.Semester = krs.Semester;
                data.Periode = krs.Periode;

                var sql2 = @"select Kode_Transkrip from Transkrip_Nilai where Nim='" + nim + "' and Periode='" + periode + "' and Semester='" + semester + "'";
                var i = conn.QueryFirstOrDefault<int>(sql2);

                if (i > 0)
                {
                    var sql1 = @"select g.id, g.Kode_matkul, m.Nama_makul, m.SKS, m.Harga, g.Grup, d.Nilai" +
                                    " from Detail_KRS de inner join Grup_makul g on de.id_makul=g.id inner join Mata_Kuliah m on g.Kode_matkul=m.Kode_matkul " +
                                     "inner join Detail_Transkrip d on g.id=d.id_makul where de.Id_krs=" + krs.Id_krs;
                    var det = conn.Query<DetailKrs_ViewModel>(sql1);
                    data.detail = det;

                }
                else
                {
                    var sql1 = @"select g.id, g.Kode_matkul, m.Nama_makul, m.SKS, m.Harga, g.Grup" +
                                   " from Detail_KRS de inner join Grup_makul g on de.id_makul=g.id inner join Mata_Kuliah m on g.Kode_matkul=m.Kode_matkul " +
                                    "where de.Id_krs=" + krs.Id_krs;
                    var det = conn.Query<DetailKrs_ViewModel>(sql1);
                    data.detail = det;
                }


            }
            return data;
        }
        public Krs GetKrs(string nim, string periode2, string semester2)
        {
            Krs data = new Krs();
            var tahun = DateTime.Now.Year;
            var bulan = DateTime.Now.Month;
            var angkatan = getAngkatan(nim);
            var semester = "";
            var periode = "";
            var sem = (Int32.Parse(tahun.ToString()) - Int32.Parse(angkatan)) * 2;
            if (bulan > 7)
            {
                sem += 1;
                periode = tahun.ToString() + "/" + (tahun + 1).ToString();
            }
            else
            {
                periode = (tahun - 1).ToString() + "/" + tahun.ToString();

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
                Krs krs = new Krs();
                if (periode2 == null && semester2 == null)
                {
                    var strSql = @"select k.Id_Krs, k.Nim, m.Nama_mhs as Nama, k.Semester, k.Periode from Krs k inner join Mahasiswa m on k.Nim=m.Nim where k.Nim=" + nim + " and k.Periode='" + periode + "' and k.Semester='" + semester + "'";
                    krs = conn.QuerySingleOrDefault<Krs>(strSql);
                }
                else
                {
                    var strSql = @"select k.Id_Krs, k.Nim, m.Nama_mhs as Nama, k.Semester, k.Periode from Krs k inner join Mahasiswa m on k.Nim=m.Nim where k.Nim=" + nim + " and k.Periode='" + periode2 + "' and k.Semester='" + semester2 + "'";
                    krs = conn.QuerySingleOrDefault<Krs>(strSql);
                }

                if (krs == null)
                {
                    var sql2 = @"insert into Krs (Nim, Semester, Periode) values(@nim, @semester, @periode)";
                    var param = new { nim = nim, semester = semester, periode = periode };
                    conn.Execute(sql2, param);

                    var sql3 = @"select k.Id_Krs, k.Nim, m.Nama_mhs as Nama, k.Semester, k.Periode from Krs k inner join Mahasiswa m on k.Nim=m.Nim where k.Nim=" + nim + " and k.Periode='" + periode + "' and k.Semester='" + semester + "'";
                    krs = conn.QuerySingleOrDefault<Krs>(sql3);
                }
                data.Id_krs = krs.Id_krs;
                data.Nim = krs.Nim;
                data.Nama = krs.Nama;
                data.Semester = krs.Semester;
                data.Periode = krs.Periode;

                var sql1 = @"select g.id, g.Kode_matkul, m.Nama_makul, m.SKS, m.Harga, g.Grup, g.Jadwal, g.Sesi, g.Ruangan, d.Nama from Detail_KRS de inner join Grup_makul g on de.id_makul=g.id inner join Mata_Kuliah m on g.Kode_matkul=m.Kode_matkul inner join Dosen d on g.Nik=d.Nik where de.Id_krs=" + krs.Id_krs;
                var det = conn.Query<DetailKrs_ViewModel>(sql1);
                data.detail = det;
            }
            return data;
        }
        public IEnumerable<KrsViewModel> GetKrsDosen(string id)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = "";
                if(id == "1") {
                 sql = @"select k.Nim, m.Nama_mhs, k.Semester, k.Periode from Krs k inner join Mahasiswa m on k.Nim=m.Nim inner join Angkatan a on m.Angkatan=a.Angkatan order by k.Periode desc";

                }
                else {
                 sql = @"select k.Nim, m.Nama_mhs, k.Semester, k.Periode from Krs k inner join Mahasiswa m on k.Nim=m.Nim inner join Angkatan a on m.Angkatan=a.Angkatan where a.Wali='" + id + "'  order by k.Periode desc";

                }
                
               
                return conn.Query<KrsViewModel>(sql);
            }
        }

        public IList<MakulViewModel> GetMakul(int semester, int kode)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {

                IList<MakulViewModel> data = new List<MakulViewModel>();
                // IList<MakulViewModel> data2 = new List<MakulViewModel>();
                IList<int> detail;
                IList<string> kodemakul;


                var sql = @"select id_makul from Detail_KRS where Id_krs=" + kode;
                detail = (IList<int>)conn.Query<int>(sql);
                var sql2 = @"select m.Kode_matkul from Detail_KRS d inner join Grup_makul g on d.id_makul=g.id inner join Mata_Kuliah m on g.Kode_matkul=m.Kode_matkul where Id_krs=" + kode;
                kodemakul = (IList<string>)conn.Query<string>(sql2);

                var sql1 = @"select g.id, m.Kode_matkul, m.Nama_makul, m.SKS, m.Harga, g.Grup, g.Jadwal, g.Sesi, g.Ruangan, d.Nama from Mata_Kuliah m inner join Grup_makul g on m.Kode_matkul=g.Kode_matkul inner join Dosen d on g.Nik=d.Nik where m.Semester=" + semester;
                data = (IList<MakulViewModel>)conn.Query<MakulViewModel>(sql1);

                foreach (var a in detail)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i].id == a)
                        {
                            data.RemoveAt(i);
                        }
                    }
                }
                foreach (var a in kodemakul)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i].Kode_Matkul == a)
                        {
                            data.RemoveAt(i);
                        }
                    }
                }
                return data;
            }
        }
        public void AddMakul(int id, int id_krs)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"insert into Detail_KRS (Id_krs,id_makul) values(@krs,@id)";
                var param = new { krs = id_krs, id = id };
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

        public void DeleteMakul(int id, int kode)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"delete from Detail_Krs where Id_krs=" + id + " and id_makul=" + kode;
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
