using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemPerwalian2020.DAL;
using SistemPerwalian2020.Models;
using System;
using System.Collections.Generic;

namespace SistemPerwalian2020.Controllers
{
    public class KrsController : Controller
    {
        private IKrs _krs;
        private IMahasiswa mhs;

        public KrsController(IKrs krs, IMahasiswa _mhs)
        {
            _krs = krs;     
            mhs = _mhs;
            // _dsn = dsn;
        }
        public IActionResult Index(string nim, string periode, string semester)
        {
            if (TempData["pesan"] != null)
            {
                ViewBag.pesan = TempData["pesan"].ToString();
            }
            if (nim == "")
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var data = _krs.GetKrs(nim, periode, semester);
                return View(data);
            }
        }



        public IActionResult EditKrs(string nim, string periode, string semester)
        {
            var data = _krs.GetKrs(nim, periode, semester);
            return View(data);

        }

        public IActionResult IndexDosen(string id)
        {
            if (TempData["pesan"] != null)
            {
                ViewBag.pesan = TempData["pesan"].ToString();
            }
            var data = _krs.GetKrsDosen(id);
            return View(data);
        }

        public List<SelectListItem> getlistnilai()
        {
            var lstnilai = new List<SelectListItem>();
            lstnilai.Add(new SelectListItem
            {
                Value = "A",
                Text = "A"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "A-",
                Text = "A-"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "B+",
                Text = "B+"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "B",
                Text = "B"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "B-",
                Text = "B-"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "C+",
                Text = "C+"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "C",
                Text = "C"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "C-",
                Text = "C-"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "D",
                Text = "D"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "E",
                Text = "E"
            });
            lstnilai.Add(new SelectListItem
            {
                Value = "F",
                Text = "F"
            });
            return lstnilai;
        }
        public IActionResult CreateNilai(string nim, string periode, string semester)
        {
            var data = _krs.GetKrsforCreate(nim, periode, semester);
            var maha = mhs.GetByNim(nim);
            ViewBag.namamhs = maha.Nama_mhs;
            var lstnilai = getlistnilai();
            ViewBag.nilai = lstnilai;
            return View(data);
        }
        [HttpPost]
        public IActionResult CreatePost(IList<DetailTranskrip> detail, string periode, string semester, string nim)
        {
            try
            {
                mhs.CreateNilai(detail, periode, semester, nim);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "Data nilai berhasil disimpan");
                return Json(new { result = "Redirect", url = Url.Action("IndexDosen", "Krs", new { id="1" }) });
            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return Json(new { result = "Redirect", url = Url.Action("IndexDosen", "Krs", new { id="1" }) });
            }
        }

        public IActionResult IndexMakul(string semester, int kode)
        {
            var data = _krs.GetMakul(Int32.Parse(semester), kode);
            return View(data);
        }

        [HttpPost]
        public IActionResult AddMakul(int kode, int id_krs)
        {
            try
            {
                _krs.AddMakul(kode, id_krs);
                return Json(new { result = "Redirect", url = Url.Action("EditKrs", "Krs", new { nim = HttpContext.Session.GetString("id") }) });
            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return Json(new { result = "Redirect", url = Url.Action("EditKrs", "Krs", new { nim = HttpContext.Session.GetString("id") }) });
            }
        }

        [HttpPost]
        public IActionResult SaveKrs(IList<DetailKrs_ViewModel> det)
        {
            try
            {
                _krs.SaveKrs(det);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "Data KRS berhasil disimpan");
                return Json(new { result = "Redirect", url = Url.Action("Index", "Krs", new { nim = HttpContext.Session.GetString("id") }) });
            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return Json(new { result = "Redirect", url = Url.Action("Index", "Krs", new { nim = HttpContext.Session.GetString("id") }) });
            }
        }

        public void DeleteMakul(int id, int kode)
        {
            try
            {
                _krs.DeleteMakul(id, kode);
            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
            }
        }

    }
}
