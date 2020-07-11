
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemPerwalian2020.DAL;
using SistemPerwalian2020.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SistemPerwalian2020.Controllers
{

    public class MataKuliahController : Controller
    {
        private IMatakuliah mk;
        private IDosen ds;

        public MataKuliahController(IMatakuliah _mhs, IDosen _ds)
        {
            mk = _mhs;
            ds = _ds;
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
        public List<SelectListItem> getlistgrup()
        {
            var lstgrup = new List<SelectListItem>();
            lstgrup.Add(new SelectListItem
            {
                Value = "A",
                Text = "A"
            });
            lstgrup.Add(new SelectListItem
            {
                Value = "B",
                Text = "B"
            });
            lstgrup.Add(new SelectListItem
            {
                Value = "C",
                Text = "C"
            });

            return lstgrup;
        }
        public List<SelectListItem> getlistdosen()
        {
            var lstdosen = new List<SelectListItem>();
            var data = ds.GetDosen();

            foreach (var dos in data)
            {
                lstdosen.Add(new SelectListItem
                {
                    Value = dos.Nik,
                    Text = dos.Nama
                });
            }

            return lstdosen;
        }
        public List<SelectListItem> getlisthari()
        {
            var lsthari = new List<SelectListItem>();
            lsthari.Add(new SelectListItem
            {
                Value = "Senin",
                Text = "Senin"
            });
            lsthari.Add(new SelectListItem
            {
                Value = "Selasa",
                Text = "Selasa"
            });
            lsthari.Add(new SelectListItem
            {
                Value = "Rabu",
                Text = "Rabu"
            });
            lsthari.Add(new SelectListItem
            {
                Value = "Kamis",
                Text = "Kamis"
            });
            lsthari.Add(new SelectListItem
            {
                Value = "Jumat",
                Text = "Jumat"
            });

            return lsthari;
        }
        public List<SelectListItem> getlistsesi()
        {
            var lstsesi = new List<SelectListItem>();
            lstsesi.Add(new SelectListItem
            {
                Value = "1",
                Text = "1"
            });
            lstsesi.Add(new SelectListItem
            {
                Value = "2",
                Text = "2"
            });
            lstsesi.Add(new SelectListItem
            {
                Value = "3",
                Text = "3"
            });
            lstsesi.Add(new SelectListItem
            {
                Value = "4",
                Text = "4"
            });

            return lstsesi;
        }
        public IActionResult Create()
        {
            var lstgrup = getlistgrup();
            ViewBag.grup = lstgrup;
            var lsthari = getlisthari();
            ViewBag.hari = lsthari;
            var lstdosen = getlistdosen();
            ViewBag.dosen = lstdosen;
            var lstsesi = getlistsesi();
            ViewBag.sesi = lstsesi;
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(MataKuliah data)
        {
            try
            {
                mk.Insert(data);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "Data Matakuliah berhasil disimpan");
                return Json(new { result = "Redirect", url = Url.Action("Index", "Matakuliah") });
            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return Json(new { result = "Redirect", url = Url.Action("Index", "Matakuliah") });
            }
        }
        public IActionResult Edit(string kode)
        {
            var data = mk.GetDatabyID(kode);
            var lstgrup = getlistgrup();
            ViewBag.grup = lstgrup;
            var lsthari = getlisthari();
            ViewBag.hari = lsthari;
            var lstdosen = getlistdosen();
            ViewBag.dosen = lstdosen;
            var lstsesi = getlistsesi();
            ViewBag.sesi = lstsesi;
            TempData["kode"] = kode;
            return View(data);
        }

        [HttpPost]
        public IActionResult EditPost(MataKuliah data)
        {
            var kode = TempData["kode"].ToString();
            try
            {
                mk.Update(kode, data);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "sukses mengubah data jadwal");
                return Json(new { result = "Redirect", url = Url.Action("Index", "Matakuliah") });

            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return Json(new { result = "Redirect", url = Url.Action("Index", "Matakuliah") });

            }
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