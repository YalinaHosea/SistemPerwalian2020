using System;
using System.ComponentModel.DataAnnotations;

namespace SistemPerwalian2020.Models
{

    public class CatatanPerwalian
    {
        public int Id_catatan { get; set; }
        public string Nim { get; set; }
        public string Nama_mhs { get; set; }
        public int Kode_jadwal { get; set; }
        public string Catatan { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy HH:mm}")]
        public DateTime Waktu { get; set; }
    }
}