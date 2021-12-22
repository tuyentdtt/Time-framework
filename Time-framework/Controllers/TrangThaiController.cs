using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Time_framework.Models;

namespace Time_framework.Controllers
{
    public class TrangThaiController : Controller
    {
        
        

        [Route("/trangthai")]
        // GET: TrangThai
        public ActionResult Index(ApplicationDbContext _context)
        {
            var TrangThaiData = (from a in _context.TrangThaiModel select a);
            return View(TrangThaiData);
        }

        // GET: TrangThai/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TrangThai/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrangThai/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TrangThai/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrangThai/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TrangThai/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrangThai/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
