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
            }}

        // [HttpPost]
        // public IActionResult Edit(Dosen data) {
        //     var nik = data.Dosen.nik;
        //     var angakatan_sub = nim_sub.Substring(2, 2);
        //     var angkatan = "20" + angakatan_sub;
        //     data.mhs.Angkatan = angkatan;
        //     try
        //     {
        //         _mhs.Update(data);
        //         TempData["pesan"] = Helpers.Message.GetPesan("success", "Data dosen berhasil diubah");
        //         return RedirectToAction("Index");
        //     }
        //     catch(Exception x) {
        //         TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
        //         return RedirectToAction("Index");
        //     }
        // }
        // }
        // public IActionResult Delete(string nik)
        // {
        //     try
        //     {
        //         dosen.Delete(nik);
        //         TempData["pesan"] = Helpers.Message.GetPesan("success", "sukses menghapus data dosen");
        //         return RedirectToAction("Index");

        //     }
        //     catch (Exception x)
        //     {
        //         TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
        //         return RedirectToAction("Index");

        //     }
        // }
    }
}