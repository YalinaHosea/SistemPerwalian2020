using System;

namespace SistemPerwalian2020.Models{

    public class Jadwal {
        public int Kode_jadwal{get; set; }
        public string Periode {get; set; }
        public string Prodi {get; set; }
        public string Grup {get; set; }
        public DateTime Waktu {get; set; }
    }
}
 