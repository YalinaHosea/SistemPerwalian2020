using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemPerwalian2020.Models
{
    public class PresensiViewModel
    {
        public int Id_presensi { get; set; }
        public string Nim { get; set; }
        public string Nama_mhs { get; set; }
        public int Kode_jadwal { get; set; }
        public Boolean Hadir { get; set; }
        public DateTime Waktu { get; set; }
    }
}
