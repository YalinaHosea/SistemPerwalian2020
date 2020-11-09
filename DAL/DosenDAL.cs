

using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemPerwalian2020.Models;
using Dapper;
using System;

namespace SistemPerwalian2020.DAL
{

    public class DosenDAL : IDosen
    {
        private IConfiguration _config;
        public DosenDAL(IConfiguration config)
        {
            _config = config;
        }
        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }

        public Dosen Login(string Id, string Password){
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select *from Dosen where Username=@Id and Password=@Password";
                var param = new {Id=Id, Password=Password};
                return conn.QueryFirstOrDefault<Dosen>(strSql, param);
            }
        }


        public IEnumerable<Dosen> GetDosen()
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Dosen where NIK!='1'";
                return conn.Query<Dosen>(strSql);
            }
        }

         public void AddDosen(Dosen dosen)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var sql = @"insert into Dosen (Nik,Nama,Password,Username) values(@Nik, @Nama, @Username, @Username)";
                var param = new { Nik = dosen.Nik, Nama = dosen.Nama, Username = dosen.Username};

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
