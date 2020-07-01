using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemPerwalian2020.Helpers
{
    public class Message
    {
        public static string GetPesan(string jenis, string pesan)
        {
            return string.Format(@"<div style='margin-top:20px; width:70%' class='alert alert-{0}'>
                              <button type='button' aria-hidden='true' class='close' data-dismiss='alert'>×</button>
                        <span>{1}</span></div>", jenis, pesan);
        }
    }
}