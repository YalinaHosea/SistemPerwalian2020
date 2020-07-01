using System.Collections.Generic;

namespace SistemPerwalian2020.Models
{
    public class TranskripViewModel
    {
        public TranskripNilai transkrip { get; set; }
        public Mahasiswa mahasiswa { get; set; }
        public IEnumerable<DetailTranskrip> detail { get; set; }
    }
}
