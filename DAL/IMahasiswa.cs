
using System.Collections.Generic;
using SistemPerwalian2020.Models;

namespace SistemPerwalian2020.DAL
{
    public interface IMahasiswa
    {
        Mahasiswa Login(string Id, string Password);
        IEnumerable<Mahasiswa> GetAll();
        IEnumerable<MakulViewModel> GetMakul(string periode, string semester);

        TranskripViewModel GetNilai(string nim, string role, string state);
        void CreateNilai(IList<DetailTranskrip> det, string periode, string semester, string nim);
        void DeleteMakul(int kode);
        string getWali(string angkatan);
        Mahasiswa GetByNim(string nim);
        void Insert(Mahasiswa mhs);
        void Update(MahasiswaViewModel mhs);
        void Delete(string nik);
        MahasiswaViewModel GetByNimVM(string nim);
    }
}
