namespace SistemPerwalian2020.Models
{

    public class DetailTranskrip
    {
        public int Kode_detail { get; set; }
        public int Kode_transkrip { get; set; }
        public string Kode_matkul { get; set; }
        public int id_makul { get; set; }
        public string Nama_makul { get; set; }
        public int SKS { get; set; }
        public string Grup { get; set; }
        public string Nilai { get; set; }
        public float Bobot { get; set; }
        public float Kualitas { get; set; }
    }

}
