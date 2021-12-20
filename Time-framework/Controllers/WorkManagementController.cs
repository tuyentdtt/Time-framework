using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Time_framework.Controllers
{
    public class WorkManagementController : Controller
    {
        [Route("/workmanagement")]
        // GET: WorkManagement
        public ActionResult Index()
        {
            return View();
        }

        // GET: WorkManagement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WorkManagement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkManagement/Create
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

        // GET: WorkManagement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WorkManagement/Edit/5
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

        // GET: WorkManagement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WorkManagement/Delete/5
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
