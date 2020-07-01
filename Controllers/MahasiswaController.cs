
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemPerwalian2020.DAL;
using SistemPerwalian2020.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SistemPerwalian2020.Controllers{

    public class MahasiswaController:Controller{
        private IMahasiswa _mhs;

        public MahasiswaController(IMahasiswa mhs)
        {
            _mhs = mhs;
        }

        public IActionResult Index()
        {
            if (TempData["pesan"] != null)
            {
                ViewBag.pesan = TempData["pesan"].ToString();
            }
            var data = _mhs.GetAll();
            return View(data);
        }

        public IActionResult Nilai(string id, string role)
        {
            var data = _mhs.GetNilai(id, role);
            if(data == null)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("warning", "Belum ada data nilai");
                if(HttpContext.Session.GetString("role") == "dosen")
                {
                return RedirectToAction("Index");

                }
                else{
                    return View(data);
                }
            }
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
        public IActionResult CreateNilai(string id, string role)
        {
            var lstnilai = getlistnilai();
            ViewBag.nilai = lstnilai;
            var data = _mhs.GetNilai(id, role);
            return View(data);
        }

        [HttpPost]
        public IActionResult CreatePost(IList<DetailTranskrip> detail)
        {
           try
            {
                _mhs.CreateNilai(detail);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "Data KRS berhasil disimpan");
                return Json(new { result = "Redirect", url = Url.Action("Index", "Mahasiswa") });
            }
            catch(Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return Json(new { result = "Redirect", url = Url.Action("Index", "Mahasiswa") });
            }
        }
        public void DeleteMakul(int id)
        {
            try
            {
                _mhs.DeleteMakul(id);
            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
            }
        }
    }
}