

using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemPerwalian2020.Models;
using Dapper;

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
        

        public Dosen Login(string id, string password)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Dosen where NIK=@Id and Password=@Password";
                var param = new { Id = id, Password = password };
                return conn.QuerySingleOrDefault<Dosen>(strSql, param);
            }
        }
    }
}
