using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SistemPerwalian2020.DAL;
using SistemPerwalian2020.Models;
using System;

namespace SistemPerwalian2020.Controllers
{
    public class AccountController : Controller
    {

        //private IMahasiswa _mhs;
        private IDosen _dsn;
        private IMahasiswa _mhs;

        public AccountController(IDosen dsn, IMahasiswa mhs)
        {
            _dsn = dsn;
            _mhs = mhs;
            // _dsn = dsn;
        }
        public IActionResult Login()
        {
            if (TempData["pesan"] != null)
            {
                ViewBag.pesan = TempData["pesan"].ToString();
            }
            return View();

        }
        [HttpPost]
        public IActionResult Login(string id, string password)
        {

            var data = _dsn.Login(id, password);
            if (data != null)
            {
                if (data.Nik == "1")
                {
                    HttpContext.Session.SetString("user", data.Nama);
                    HttpContext.Session.SetString("id", data.Nik);
                    HttpContext.Session.SetString("role", "superadmin");
                }
                else
                {
                    HttpContext.Session.SetString("user", data.Nama);
                    HttpContext.Session.SetString("id", data.Nik);
                    HttpContext.Session.SetString("role", "dosen");
                    // HttpContext.Session.SetString("grup", data.Grup);
                }

            }
            else
            {
                var data2 = _mhs.Login(id, password);
                if (data2 != null)
                {
                    HttpContext.Session.SetString("user", data2.Nama_mhs);
                    HttpContext.Session.SetString("id", data2.Nim);
                    HttpContext.Session.SetString("role", "mahasiswa");
                    // HttpContext.Session.SetString("grup", "");
                    var angkatan = Int32.Parse(data2.Angkatan);
                                        HttpContext.Session.SetString("angkatan", angkatan.ToString());

                    var tgl = Int32.Parse(DateTime.Now.Year.ToString());
                    var month = DateTime.Now.Month;
                    var semester = (tgl - angkatan) * 2;
                    if(month > 6) {
                        semester += 1;
                    }
                    HttpContext.Session.SetString("semester", semester.ToString());
                    var wali = _mhs.getWali(data2.Angkatan);
                    HttpContext.Session.SetString("wali", wali);
                }
                else
                {
                    TempData["pesan"] = Helpers.Message.GetPesan("danger", "id atau password salah");
                    return RedirectToAction("Login", "Account");
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("user", "");
            HttpContext.Session.SetString("id", "");
            HttpContext.Session.SetString("role", "");
            HttpContext.Session.SetString("angkatan", "");
            return RedirectToAction("Index", "Home");
        }
    }

}


