using System.Collections.Generic;
using SistemPerwalian2020.Models;

namespace SistemPerwalian2020.DAL
{
    public interface IKrs
    {

        Krs GetKrs(string nim, string periode, string semester);
        Krs GetKrsforCreate(string nim, string periode, string semester);
        IEnumerable<KrsViewModel> GetKrsDosen(string id);
        IList<MakulViewModel> GetMakul(int semester, int kode);
        void AddMakul(int id, int id_krs);
        void SaveKrs(IList<DetailKrs_ViewModel> detail);
        void DeleteMakul(int id, int kode);
    }
}