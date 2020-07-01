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
        public string Semester { get; set; }
        public IEnumerable<DetailKrs_ViewModel> detail { get; set; }
    }

    public class DetailKrs_ViewModel
    {
        public int Id_krs { get; set; }
        public string Kode_Matkul { get; set; }
        public string Nama_Makul { get; set; }
        public string SKS { get; set; }
    }
}
