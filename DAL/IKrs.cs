using System.Collections.Generic;
using SistemPerwalian2020.Models;

namespace SistemPerwalian2020.DAL
{
    public interface IKrs
    {
      
        Krs GetKrs(string nim);
        IEnumerable<MataKuliah> GetMakul();
        void SaveKrs(IList<DetailKrs_ViewModel> detail);
        void DeleteMakul(int id, string kode);
    }
}