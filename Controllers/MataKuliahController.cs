
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemPerwalian2020.DAL;
using SistemPerwalian2020.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SistemPerwalian2020.Controllers{

    public class MataKuliahController:Controller{
        private IMatakuliah mk;

        public MataKuliahController(IMatakuliah _mhs)
        {
            mk = _mhs;
        }
         public IActionResult Index()
        {
            if (TempData["pesan"] != null)
            {
                ViewBag.pesan = TempData["pesan"].ToString();
            }
            var data = mk.GetAll();
            return View(data);
        }

         public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(MataKuliah data)
        {
            try
            {
                mk.Insert(data);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "sukses menambah data jadwal");

            }
            catch(Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                
            }
            return Redirect("Index");
        }
        public IActionResult Edit(string kode)
        {
            var data = mk.GetDatabyID(kode);
            TempData["kode"] = kode;
            return View(data);
        }

        [HttpPost]
        public IActionResult EditPost(MataKuliah data)
        {
            var kode = TempData["kode"].ToString();
            try
            {
                mk.Update(kode,data);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "sukses mengubah data jadwal");

            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string kode)
        {
            try
            {
                mk.DeleteMakul(kode);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "sukses menghapus data jadwal");
                return RedirectToAction("Index");

            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return RedirectToAction("Index");

            }
        }

    }
}