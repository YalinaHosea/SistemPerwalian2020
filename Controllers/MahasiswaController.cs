
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemPerwalian2020.DAL;
using SistemPerwalian2020.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SistemPerwalian2020.Controllers
{

    public class MahasiswaController : Controller
    {
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

        public IActionResult Nilai(string id, string role, string state)
        {
            var data = _mhs.GetNilai(id, role, state);
            if (data == null && HttpContext.Session.GetString("role") != "mahasiswa")
            {
                TempData["pesan"] = Helpers.Message.GetPesan("warning", "Belum ada data nilai");

                return RedirectToAction("Index");
            }
            return View(data);
        }

        public IActionResult IndexMakul(string periode, string semester)
        {
            var data = _mhs.GetMakul(periode, semester);
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
        public List<SelectListItem> getlistsemester()
        {
            var lstsemester = new List<SelectListItem>();
            lstsemester.Add(new SelectListItem
            {
                Value = "Ganjil",
                Text = "Ganjil"
            });
            lstsemester.Add(new SelectListItem
            {
                Value = "Genap",
                Text = "Genap"
            });
            return lstsemester;
        }
        public List<SelectListItem> getlistyear()
        {
            var lstyear = new List<SelectListItem>();
            var year = DateTime.Now.Year;

            lstyear.Add(new SelectListItem
            {
                Value = (year + 1).ToString(),
                Text = (year + 1).ToString()
            });
            lstyear.Add(new SelectListItem
            {
                Value = year.ToString(),
                Text = year.ToString()
            });
            for (var i = 1; i <= 5; i++)
            {
                lstyear.Add(new SelectListItem
                {
                    Value = (year - i).ToString(),
                    Text = (year - i).ToString()
                });
            }
            return lstyear;
        }
         public List<SelectListItem> getliststatus()
        {
            var lststatus = new List<SelectListItem>();

            lststatus.Add(new SelectListItem
            {
                Value = "Ya",
                Text = "Ya"
            });
             lststatus.Add(new SelectListItem
            {
                Value = "Tidak",
                Text = "Tidak"
            });
            return lststatus;
        }

        public IActionResult Create() {
            // var lststatus = getliststatus();
            // ViewBag.status = lststatus;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mahasiswa mhs) {
            var nim_sub = mhs.Nim;
            var angakatan_sub = nim_sub.Substring(2, 2);
            var angkatan = "20" + angakatan_sub;
            mhs.Angkatan = angkatan;
            mhs.Status = "Aktif";
            try
            {
                _mhs.Insert(mhs);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "Data mahasiswa berhasil disimpan");
                return RedirectToAction("Index");
            }
            catch(Exception x) {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Edit(string nim) {
            var data = _mhs.GetByNimVM(nim);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(MahasiswaViewModel data) {
            var nim_sub = data.mhs.Nim;
            var angakatan_sub = nim_sub.Substring(2, 2);
            var angkatan = "20" + angakatan_sub;
            data.mhs.Angkatan = angkatan;
            try
            {
                _mhs.Update(data);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "Data mahasiswa berhasil diubah");
                return RedirectToAction("Index");
            }
            catch(Exception x) {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delete(string nim)
        {
            try
            {
                _mhs.Delete(nim);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "sukses menghapus data mahasiswa");
                return RedirectToAction("Index");

            }
            catch (Exception x)
            {
                TempData["pesan"] = Helpers.Message.GetPesan("danger", x.Message);
                return RedirectToAction("Index");

            }
        }


        public IActionResult CreateNilai(string id)
        {
            var lstnilai = getlistnilai();
            ViewBag.nilai = lstnilai;
            var lstsemester = getlistsemester();
            ViewBag.semester = lstsemester;
            var lstyear = getlistyear();
            ViewBag.year = lstyear;
            var data = _mhs.GetByNim(id);
            ViewBag.namamhs = data.Nama_mhs;
            ViewBag.nimmhs = data.Nim;
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(IList<DetailTranskrip> detail, string periode, string semester, string nim)
        {
            try
            {
                _mhs.CreateNilai(detail, periode, semester, nim);
                TempData["pesan"] = Helpers.Message.GetPesan("success", "Data KRS berhasil disimpan");
                return Json(new { result = "Redirect", url = Url.Action("Index", "Mahasiswa") });
            }
            catch (Exception x)
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