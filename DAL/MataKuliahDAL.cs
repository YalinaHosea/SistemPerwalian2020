using System.Collections.Generic;
using SistemPerwalian2020.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemPerwalian2020.DAL;
using System;

namespace SistemPerwalian2020.DAL
{
    public class MatakuliahDAL : IMatakuliah
    {
        private IConfiguration _config;

        public MatakuliahDAL(IConfiguration config)
        {
            _config = config;
        }
        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }



        public void DeleteMakul(string kode)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"delete from Mata_Kuliah where Kode_matkul='" + kode + "'";
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

        public MakulVM GetAll()
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                MakulVM makul = new MakulVM();
                var strSql = @"select * from Mata_Kuliah order by Semester";
                makul.makul = conn.Query<MataKuliah>(strSql);
                var strSql2 = @"select g.Grup, g.Kode_matkul, g.Jadwal, g.Sesi, g.Ruangan, d.Nama from Grup_makul g inner join Dosen d on g.Nik=d.Nik";
                makul.grup = conn.Query<Grup_makul>(strSql2);
                return makul;
            }
        }
        public MataKuliah GetDatabyID(string kode)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                MataKuliah mk = new MataKuliah();
                var strSql = @"select * from Mata_Kuliah where Kode_matkul='" + kode + "'";
                var data = conn.QueryFirstOrDefault<MataKuliah>(strSql);
                mk.Kode_Matkul = data.Kode_Matkul;
                mk.Nama_Makul = data.Nama_Makul;
                mk.Harga = data.Harga;
                mk.Semester = data.Semester;
                mk.SKS = data.SKS;

                var strSql2 = @"select * from Grup_makul where Kode_matkul='" + kode + "'";
                mk.grup = conn.Query<Grup_makul>(strSql2);
                return mk;

            }
        }

        public void Insert(MataKuliah mhs)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"insert into Mata_Kuliah (Kode_matkul,Nama_makul,SKS,Semester,Harga) values(@id, @nama,@sks,@semester,@harga)";
                var param = new { id = mhs.Kode_Matkul, nama = mhs.Nama_Makul, sks = mhs.SKS, semester = mhs.Semester, harga = mhs.Harga };

                try
                {
                    conn.Execute(sql, param);
                }
                catch (SqlException x)
                {
                    throw new Exception($"error : {x.Message}");
                }
                foreach (var grup in mhs.grup)
                {
                    var sql2 = @"insert into Grup_makul (Kode_matkul,Grup,Jadwal,Sesi,Ruangan,Nik) values(@kode,@grup,@jadwal,@sesi,@ruangan,@nik)";
                    var param2 = new { kode = mhs.Kode_Matkul, grup = grup.Grup, jadwal = grup.Jadwal, sesi = grup.Sesi, ruangan = grup.Ruangan, nik = grup.Nik };
                    try
                    {
                        conn.Execute(sql2, param2);
                    }
                    catch (SqlException x)
                    {
                        throw new Exception($"error : {x.Message}");
                    }
                }
            }
        }

        public void Update(string kode, MataKuliah mhs)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {

                var strsql = @"update Mata_Kuliah set Kode_matkul=@kode, Nama_makul=@nama, SKS=@sks, Semester=@semester where Kode_matkul='" + kode + "'";
                var param = new { kode = mhs.Kode_Matkul, nama = mhs.Nama_Makul, sks = mhs.SKS, semester = mhs.Semester };
                try
                {
                    conn.Execute(strsql, param);
                }
                catch (SqlException x)
                {
                    throw new Exception($"error : {x.Message}");
                };

                foreach (var grup in mhs.grup)
                {
                    var sqlcek = @"select id from Grup_makul where Kode_matkul='" + mhs.Kode_Matkul + "' and Grup='" + grup.Grup + "'";
                    var id = conn.QueryFirstOrDefault<string>(sqlcek);

                    if (id == null)
                    {
                        var sql2 = @"insert into Grup_makul (Kode_matkul,Grup,Jadwal,Sesi,Ruangan,Nik) values(@kode,@grup,@jadwal,@sesi,@ruangan,@nik)";
                        var param2 = new { kode = mhs.Kode_Matkul, grup = grup.Grup, jadwal = grup.Jadwal, sesi = grup.Sesi, ruangan = grup.Ruangan, nik = grup.Nik };
                        try
                        {
                            conn.Execute(sql2, param2);
                        }
                        catch (SqlException x)
                        {
                            throw new Exception($"error : {x.Message}");
                        }
                    }
                    else
                    {
                        var sql2 = @"update Grup_makul set Grup=@grup, Jadwal=@jadwal, Sesi=@sesi, Ruangan=@ruangan, Nik=@nik where id=" + id;
                        var param2 = new { grup = grup.Grup, jadwal = grup.Jadwal, sesi = grup.Sesi, ruangan = grup.Ruangan, nik = grup.Nik };
                        try
                        {
                            conn.Execute(sql2, param2);
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