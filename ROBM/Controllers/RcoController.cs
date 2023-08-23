using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROBM.Controllers
{
    public class RcoController : Controller
    {
        // GET: Rco
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rco/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rco/Create
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

        // GET: Rco/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rco/Edit/5
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

        // GET: Rco/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rco/Delete/5
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
