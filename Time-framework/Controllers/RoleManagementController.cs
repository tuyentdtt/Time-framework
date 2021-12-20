using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Time_framework.Controllers
{
    public class RoleManagementController : Controller
    {
        [Route("/rolemanagement")]
        // GET: RoleManagement
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoleManagement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoleManagement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleManagement/Create
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

        // GET: RoleManagement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoleManagement/Edit/5
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

        // GET: RoleManagement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoleManagement/Delete/5
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
