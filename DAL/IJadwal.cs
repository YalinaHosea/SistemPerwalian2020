using System.Collections.Generic;
using SistemPerwalian2020.Models;

namespace SistemPerwalian2020.DAL
{
    public interface IJadwal
    {
        IEnumerable<Jadwal> GetJadwals();
        Jadwal GetJadwalbyId(int id);
        IList<PresensiViewModel> GetPresensi(int id, string grup);
        void UpdatePresensi(IList<PresensiViewModel> presensi);
        IList<CatatanPerwalian> GetCatatan(int id, string grup);
        void UpdateCatatan(IList<CatatanPerwalian> catatan);
        IList<CatatanPerwalian> GetCatatanbyNim(string nim);
        void Insert(Jadwal jdw);
        void Update(Jadwal mhs);
        void Delete(int id);
    }
}
