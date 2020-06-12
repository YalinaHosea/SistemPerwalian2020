

using System.Collections.Generic;
using SistemPerwalian2020.Models;

namespace SistemPerwalian.DAL{
    public interface IMahasiswa
    {
        IEnumerable<Mahasiswa> Login(string Id, string Password);
        IEnumerable<Mahasiswa> GetAll();

        Mahasiswa GetByNim(string nim);

        void Insert(Mahasiswa mhs);
        void Update (Mahasiswa mhs);
        void Delete(Mahasiswa mhs);
    }
}