using System;
using Microsoft.AspNetCore.Mvc;
using SistemPerwalian2020.DAL;
using SistemPerwalian2020.Models;

namespace SistemPerwalian2020.Controllers{
    public class DosenController : Controller{
 private IDosen _dsn;

 public DosenController(IDosen dsn)
        {
            _dsn = dsn;
            // _dsn = dsn;
        }
        public IActionResult Index(){
             var data = _dsn.GetDosen();
            return View(data);
        }
       public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Dosen dsn){
              try
            {
                _dsn.AddDosen(dsn);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "Data Dosen berhasil disimpan");
                return RedirectToAction("Index");
            }
            catch(Exception x) {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return RedirectToAction("Index");
            }

        }

    }
}