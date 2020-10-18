using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemPerwalian2020.Models
{

    public class Krs
    {
        public int Id_krs { get; set; }
        public string Nim { get; set; }
        public string Nama {get;set;}
        public string Semester { get; set; }
        public string Periode { get; set; }

        public IEnumerable<DetailKrs_ViewModel> detail { get; set; }
    }

    public class DetailKrs_ViewModel
    {
        public int Id_krs { get; set; }
        public int id { get; set; }
        public string Kode_Matkul { get; set; }
        public string Nama_Makul { get; set; }
        public string SKS { get; set; }
        public float Harga { get; set; }
        public string Grup { get; set; }
        public string Jadwal { get; set; }
        public string Nilai { get; set; }
        public int Sesi { get; set; }
        public string Ruangan { get; set; }
        public string Nama { get; set; }
    }
}
