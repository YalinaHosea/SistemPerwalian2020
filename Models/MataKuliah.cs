using System.Collections.Generic;

namespace SistemPerwalian2020.Models
{

    public class MataKuliah
    {
        public string Kode_Matkul { get; set; }
        public string Nama_Makul { get; set; }
        public int SKS { get; set; }
        public int Semester { get; set; }
        public float Harga { get; set; }
        public IEnumerable<Grup_makul> grup { get; set; }
    }
}