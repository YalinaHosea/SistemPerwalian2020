using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemPerwalian2020.DAL;
using SistemPerwalian2020.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemPerwalian2020.Controllers
{

    public class JadwalController : Controller
    {
        private IJadwal _jdw;

        public JadwalController(IJadwal jdw)
        {
            _jdw = jdw;
        }

        public IActionResult Index()
        {
            if (TempData["pesan"] != null)
            {
                ViewBag.pesan = TempData["pesan"].ToString();
            }
            var data = _jdw.GetJadwals();
            return View(data);
        }


        public IActionResult Presensi(int id, string grup)
        {
            var data = _jdw.GetPresensi(id, grup);
            var jadwal = _jdw.GetJadwalbyId(id);
            ViewBag.grup = jadwal.Dosen;
            ViewBag.prodi = jadwal.Prodi;
            ViewBag.waktu = jadwal.Waktu;
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdatePresensi(IList<PresensiViewModel> presensi)
        {
            try
            {
                _jdw.UpdatePresensi(presensi);
                return RedirectToAction("Index");
            }
            catch (Exception x)
            {
                return Content($"error : {x.Message}");
            };
        }
        public IActionResult CatatanMahasiswa(string nim)
        {
            var data = _jdw.GetCatatanbyNim(nim);
            return View(data);
        }

        public IActionResult Catatan(int id, string grup)
        {
            var data = _jdw.GetCatatan(id, grup);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateCatatan(IList<CatatanPerwalian> catatan)
        {
            try
            {
                _jdw.UpdateCatatan(catatan);
                return RedirectToAction("Index");
            }
            catch (Exception x)
            {
                return Content($"error : {x.Message}");
            };
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
         public List<SelectListItem> getlistangkatan()
        {
            var lstangkatan = new List<SelectListItem>();
            var nik = HttpContext.Session.GetString("id");
            var data = _jdw.getAngkatan(nik);

            foreach (var dos in data)
            {
                lstangkatan.Add(new SelectListItem
                {
                    Value = dos.angkatan,
                    Text = dos.angkatan
                });
            }

            return lstangkatan;
        }
        public IActionResult Create()
        {
            var lstgrup = getlistgrup();
            ViewBag.grup = lstgrup;
            var lstangkatan = getlistangkatan();
            ViewBag.angkatan = lstangkatan;
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(Jadwal jdw)
        {
            // if (HttpContext.Session.GetString("role") == "dosen")
            // {
            //     jdw.Angkatan = HttpContext.Session.GetString("id");
            // }
            try
            {
                _jdw.Insert(jdw);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "sukses menambah data jadwal");

            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);

            }
            return Redirect("Index");
        }

        public IActionResult Edit(int id)
        {
            var data = _jdw.GetJadwalbyId(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult EditPost(Jadwal data)
        {
            try
            {
                _jdw.Update(data);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "sukses mengubah data jadwal");

            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            try
            {
                _jdw.Delete(id);
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