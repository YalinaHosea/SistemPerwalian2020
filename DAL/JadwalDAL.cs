using System.Collections.Generic;
using SistemPerwalian2020.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemPerwalian2020.DAL;
using System;
using System.Linq;

namespace SistemPerwalian2020.DAL
{
    public class JadwalDAL : IJadwal
    {
        private IConfiguration _config;

        public JadwalDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"delete from Jadwal_perwalian where Kode_jadwal=" + id;
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

        public IEnumerable<Jadwal> GetJadwals()
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select j.Kode_Jadwal, j.Periode ,j.Angkatan, d.Nama as Dosen, j.Prodi, j.Waktu from Jadwal_Perwalian j inner join Angkatan a on j.Angkatan=a.Angkatan inner join Dosen d on a.Wali=d.Nik order by j.Kode_Jadwal";
                return conn.Query<Jadwal>(strSql);
            }
        }
        public Jadwal GetJadwalbyID(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Jadwal_Perwalian where Kode_Jadwal=" + id;
                return conn.QueryFirstOrDefault<Jadwal>(strSql);
            }
        }
       public IList<PresensiViewModel> GetPresensi(int id, string grup)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var str = @"select p.NIM, m.Nama_mhs, p.Kode_Jadwal, p.Hadir, p.Waktu from Presensi p inner join Mahasiswa m on p.NIM=m.NIM where p.Kode_Jadwal=" + id + " and m.Grup='" + grup + "'";
                var data = (IList<PresensiViewModel>)conn.Query<PresensiViewModel>(str);

                if (data.Any())
                {
                    return data;
                }
                else
                {
                    var str2 = @"select * from Mahasiswa where Grup='" + grup + "' order by NIM";
                    var datamhs = conn.Query<Mahasiswa>(str2);
                    var tgl = DateTime.Now;
                    foreach (var i in datamhs)
                    {
                        var str3 = @"insert into Presensi(NIM,Kode_Jadwal,Hadir,Waktu) values(@nim,@kode,@hadir,@waktu)";

                        try
                        {
                            var param = new { nim = i.Nim, kode = id, hadir = false, waktu=tgl };
                            conn.Execute(str3, param);
                        }
                        catch (SqlException x)
                        {
                            throw new Exception($"error : {x.Message}");
                        };
                    }
                    var strSql = @"select p.NIM, m.Nama_mhs, p.Kode_Jadwal, p.Hadir, p.Waktu from Presensi p inner join Mahasiswa m on p.NIM=m.NIM where p.Kode_Jadwal=" + id + " and m.Grup='" + grup + "'";
                    return (IList<PresensiViewModel>)conn.Query<PresensiViewModel>(str);
                }


            }
        }
        public void UpdatePresensi(IList<PresensiViewModel> presensi)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var tgl = DateTime.Now;
                foreach (var data in presensi)
                {
                    var strsql = @"update Presensi set Hadir='" + data.Hadir + "', Waktu='" + tgl.ToString("yyyy-MM-dd HH:mm:ss") + "' where Kode_Jadwal=" + data.Kode_jadwal + " and Nim=" + data.Nim;
                    try
                    {
                        conn.Execute(strsql);
                    }
                    catch (SqlException x)
                    {
                        throw new Exception($"error : {x.Message}");
                    };
                }
            }
        }
                public IList<CatatanPerwalian> GetCatatan(int id, string grup)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var str = @"select p.NIM, m.Nama_mhs, p.Kode_Jadwal, p.Catatan, p.Waktu from Catatan_Perwalian p inner join Mahasiswa m on p.Nim=m.Nim where p.Kode_Jadwal=" + id + " and m.Grup='" + grup + "'";
                var data = (IList<CatatanPerwalian>)conn.Query<CatatanPerwalian>(str);

                if (data.Any())
                {
                    return data;
                }
                else
                {
                    var str2 = @"select * from Mahasiswa where Grup='" + grup + "' order by NIM";
                    var datamhs = conn.Query<Mahasiswa>(str2);

                    foreach (var i in datamhs)
                    {
                        var str3 = @"insert into Catatan_Perwalian(NIM,Kode_Jadwal,Catatan) values(@nim,@kode,@catatan)";

                        try
                        {
                            var param = new { nim = i.Nim, kode = id, catatan = "" };
                            conn.Execute(str3, param);
                        }
                        catch (SqlException x)
                        {
                            throw new Exception($"error : {x.Message}");
                        };
                    }
                    var strSql = @"select p.NIM, m.Nama_mhs, p.Kode_Jadwal, p.Catatan, p.Waktu from Catatan_Perwalian p inner join Mahasiswa m on p.Nim=m.Nim where p.Kode_Jadwal=" + id + " and m.Grup='" + grup + "'";
                    return (IList<CatatanPerwalian>)conn.Query<CatatanPerwalian>(str);
                }


            }
        }
        public IList<CatatanPerwalian> GetCatatanbyNim(string nim)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var str = @"select * from Catatan_Perwalian where NIM='" + nim + "'";
                return (IList<CatatanPerwalian>)conn.Query<CatatanPerwalian>(str);
            }
        }

        public void UpdateCatatan(IList<CatatanPerwalian> catatan)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var tgl = DateTime.Now;
                foreach (var data in catatan)
                {
                    var strsql = @"update Catatan_Perwalian set Catatan='" + data.Catatan + "', Waktu='"+ tgl.ToString("yyyy-MM-dd HH:mm:ss") + "' where Kode_Jadwal=" + data.Kode_jadwal + " and Nim=" + data.Nim;
                    try
                    {
                        conn.Execute(strsql);
                    }
                    catch (SqlException x)
                    {
                        throw new Exception($"error : {x.Message}");
                    };
                }
            }
        }
        public void Insert(Jadwal mhs)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {

                var strsql = @"insert into Jadwal_Perwalian (Periode,Prodi,Angkatan,Waktu) values(@periode, @prodi, @angkatan, @waktu)";
                var param = new { periode = mhs.Periode, prodi = mhs.Prodi, angkatan = mhs.Angkatan, waktu = mhs.Waktu };
                try
                {
                    conn.Execute(strsql, param);
                }
                catch (SqlException x)
                {
                    throw new Exception($"error : {x.Message}");
                };

            }
        }

        public void Update(Jadwal mhs)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {

                var strsql = @"update Jadwal_Perwalian set Periode=@periode, Prodi=@prodi, Dosen=@dosen, Waktu=@waktu where Kode_jadwal=" + mhs.Kode_jadwal;
                var param = new { periode = mhs.Periode, prodi = mhs.Prodi, dosen = mhs.Dosen, waktu = mhs.Waktu };
                try
                {
                    conn.Execute(strsql, param);
                }
                catch (SqlException x)
                {
                    throw new Exception($"error : {x.Message}");
                };

            }
        }

        public Jadwal GetJadwalbyId(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Jadwal_Perwalian where Kode_Jadwal=" + id;
                return conn.QuerySingleOrDefault<Jadwal>(strSql);
            }
        }

        public IEnumerable<Angkatan> getAngkatan(string nik)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                if(nik != null) {
var strSql = @"select * from Angkatan where Wali='" + nik + "'";
                return conn.Query<Angkatan>(strSql);
                }
                else{
var strSql = @"select * from Angkatan";
                return conn.Query<Angkatan>(strSql);
                }
                
            }
        }
    }
}