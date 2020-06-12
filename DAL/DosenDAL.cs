

using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemPerwalian2020.Models;
using Dapper;

namespace SistemPerwalian2020.DAL {

    public class AdminDAL : IDosen
    {
        private IConfiguration _config;
        public AdminDAL(IConfiguration config)
        {
            _config = config;
        }
        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }
        public IEnumerable<Dosen> Login(string Id, string Password)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Admin where email=@email and password=@password";
                var param = new {Id=Id, Password=Password};
                return conn.Query<Dosen>(strSql,param);   
            }
                     }
    }
}