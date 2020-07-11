using System.Collections.Generic;

namespace SistemPerwalian2020.Models
{

    public class MakulVM
    {

        public IEnumerable<MataKuliah> makul { get; set; }

        public IEnumerable<Grup_makul> grup { get; set; }

    }
}
