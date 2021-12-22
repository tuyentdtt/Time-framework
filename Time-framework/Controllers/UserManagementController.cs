using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Time_framework.Models;

namespace Time_framework.Controllers
{
    public class UserManagementController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public UserManagementController()
        {
        }

        public UserManagementController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        [Route("/usermanagement")]
        // GET: UserManagement
        public ActionResult Index( ApplicationUserManager userManager)
        {
            var nhanvien = (userManager.Users).ToList();
            ViewBag.nhanviens = nhanvien;
            //TH2:
            //var nhanvien = _db.NHANVIENs.ToList();
            //ViewBag.nhanviens = nhanvien;

            return View();

        }

        // GET: UserManagement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserManagement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserManagement/Create
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

        // GET: UserManagement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserManagement/Edit/5
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

        // GET: UserManagement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserManagement/Delete/5
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
