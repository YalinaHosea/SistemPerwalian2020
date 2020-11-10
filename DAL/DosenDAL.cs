

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
                var strSql = @"select * from Dosen where Nik!='1'";
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
        //   public void Update(Dosen dosen)
        // {
        //      using (SqlConnection conn = new SqlConnection(GetConnStr()))
        //     {
        //         var strsql = @"update Dosen set Nik=@Nik, Nama=@nama, Username=@username, Dosen=@Dosen where Nik='" + dosen.oldNik + "'";
        //         var param = new { Nik = dosen.dosen.Nik, nama = dosen.dosen.Nama, username = dosem.dosen.Username, dosen = dosen.dosen.Dosen };
        //         try
        //         {
        //             conn.Execute(strsql, param);
        //         }
        //         catch (SqlException x)
        //         {
        //             throw new Exception($"error : {x.Message}");
        //         };       
        //     }
        //  }
        //   public void Delete(string Nik) {
        //       using (SqlConnection conn = new SqlConnection(GetConnStr()))
        //     {
        //         var sql = @"delete from Dosen where Nik='" + Nik + "'";
        //         try
        //         {
        //             conn.Execute(sql);
        //         }
        //         catch (SqlException x)
        //         {
        //             throw new Exception($"error : {x.Message}");
        //         }
        //     }
        //  }
    }
}
