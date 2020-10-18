using System;
using System.ComponentModel.DataAnnotations;

namespace SistemPerwalian2020.Models
{

    public class CatatanReport
    {
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy HH:mm}")]
        public DateTime Waktu { get; set; }
        public String Periode {get;set;}
        public string Catatan { get; set; }
    }
}