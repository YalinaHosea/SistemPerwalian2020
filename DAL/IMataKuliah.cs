
using System.Collections.Generic;
using SistemPerwalian2020.Models;

namespace SistemPerwalian2020.DAL{
    public interface IMatakuliah
    {
       MakulVM GetAll();
        void DeleteMakul(string kode);
        MataKuliah GetDatabyID(string kode);
        void Insert(MataKuliah mhs);
        void Update (string kode, MataKuliah mhs);
    }
}
