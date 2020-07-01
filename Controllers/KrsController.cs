using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemPerwalian2020.DAL;
using SistemPerwalian2020.Models;
using System;
using System.Collections.Generic;

namespace SistemPerwalian2020.Controllers
{
    public class KrsController : Controller
    {
        private IKrs _krs;

        public KrsController(IKrs krs)
        {
            _krs = krs;
            // _dsn = dsn;
        }
        public IActionResult Index()
        {
            var nim = HttpContext.Session.GetString("id");
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
                var data = _krs.GetKrs(nim);
                return View(data);
            }
        }

        public IActionResult EditKrs()
        {
            var nim = HttpContext.Session.GetString("id");

            if (nim == "")
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var data = _krs.GetKrs(nim);
                return View(data);
            }
        }

        public IActionResult IndexMakul()
        {
            var data = _krs.GetMakul();
            return View(data);
        }

        [HttpPost]
        public IActionResult SaveKrs(IList<DetailKrs_ViewModel> det)
        {
            try
            {
                _krs.SaveKrs(det);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "Data KRS berhasil disimpan");
                return Json(new { result = "Redirect", url = Url.Action("Index", "Krs") });
            }
            catch(Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return Json(new { result = "Redirect", url = Url.Action("Index", "Krs") });
            }
        }

        public void DeleteMakul(int id, string kode)
        {
            try
            {
                _krs.DeleteMakul(id, kode);
            }
            catch(Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
            }
        }

    }
}
