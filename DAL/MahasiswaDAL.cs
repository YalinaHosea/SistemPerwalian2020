

using System.Collections.Generic;
using SistemPerwalian2020.Models;
using Dapper; 
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemPerwalian.DAL;

namespace SistemPerwalian2020.DAL{
    public class MahasiswaDAL : IMahasiswa
    {
        private IConfiguration _config;
        
        public MahasiswaDAL(IConfiguration config){
            _config = config;
        }

        private string GetConnStr(){
             return _config.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<Mahasiswa> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Mahasiswa order by Nama_mhs";
                return conn.Query<Mahasiswa>(strSql);
            }
        }
        public void Delete(Mahasiswa mhs)
        {
            throw new System.NotImplementedException();
        }

        public Mahasiswa GetByNim(string nim)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Mahasiswa mhs)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Mahasiswa mhs)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Mahasiswa> Login(string Id, string Password)
        {
            throw new System.NotImplementedException();
        }
    }
}