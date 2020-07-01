
using System.Collections.Generic;
using SistemPerwalian2020.Models;

namespace SistemPerwalian2020.DAL{
    public interface IMahasiswa
    {
       Mahasiswa Login(string Id, string Password);
        IEnumerable<Mahasiswa> GetAll();
        TranskripViewModel GetNilai(string nim, string role);
        void CreateNilai(IList<DetailTranskrip> det);
        void DeleteMakul(int kode);

        Mahasiswa GetByNim(string nim);

        void Insert(Mahasiswa mhs);
        void Update (Mahasiswa mhs);
    }
}
