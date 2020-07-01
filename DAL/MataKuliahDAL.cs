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

        public IEnumerable<MataKuliah> GetAll()
        {
             using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Mata_Kuliah order by Semester";
                return conn.Query<MataKuliah>(strSql);
            }
        }
        public MataKuliah GetDatabyID(string kode)
        {
             using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Mata_Kuliah where Kode_matkul='" + kode + "'";
                return conn.QueryFirstOrDefault<MataKuliah>(strSql);
            }
        }

        public void Insert(MataKuliah mhs)
        {
             using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
            var sql = @"insert into Mata_Kuliah (Kode_matkul,Nama_makul,SKS,Semester) values(@id, @nama,@sks,@semester)";
               var param = new { id = mhs.Kode_Matkul, nama = mhs.Nama_Makul, sks = mhs.SKS, semester = mhs.Semester};

                try {
                    conn.Execute(sql,param);
                }
                catch(SqlException x)
                        {
                            throw new Exception($"error : {x.Message}");
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

            }
        }
    }
}