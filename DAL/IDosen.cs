using System.Collections.Generic;
using SistemPerwalian2020.Models;

namespace SistemPerwalian2020.DAL {
    public interface IDosen
    {
        IEnumerable<Dosen> Login(string Id, string Password);
        
    }

}