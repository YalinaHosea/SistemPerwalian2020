using System;
using System.ComponentModel.DataAnnotations;

namespace SistemPerwalian2020.Models
{

    public class JadwalViewModelReport
    {
        public string Nim {get;set;}
        public string Nama_mhs { get; set; }
        public string Hadir { get; set; }
        public string Catatan { get; set; }
    }
}
