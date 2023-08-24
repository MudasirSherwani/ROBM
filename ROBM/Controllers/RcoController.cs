using ROBM.Models;
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
            var rcos = from e in GetRcoList()
                            orderby e.RCO_Id
                            select e;
            return View(rcos);
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

        // Corrected: Move the method inside the controller class
        [NonAction]
        public List<Rco> GetRcoList()
        {
            return new List<Rco>{
                new Rco{
                    RCO_Id = 1,
                    Ref_No = "16157311163900",
                    ERO_No = 1,
                    ERO_Issue_Date = DateTime.Parse(DateTime.Today.ToString()),
                    ERO_Amount = 16000,
                    ERO_Implement_Date = DateTime.Parse(DateTime.Today.ToString()),
                    Arrear = 0,
                    RCO_Fee = 1000,
                    CRC_Remarks = "",
                    User_Name = "Mudasir",
                    Create_Date = DateTime.Parse(DateTime.Today.ToString()),
                    Create_Time =DateTime.Parse(DateTime.Today.ToString()),
                },

                new Rco{
                    RCO_Id = 2,
                    Ref_No = "16157311163901",
                    ERO_No = 11,
                    ERO_Issue_Date = DateTime.Parse(DateTime.Today.ToString()),
                    ERO_Amount = 18000,
                    ERO_Implement_Date = DateTime.Parse(DateTime.Today.ToString()),
                    Arrear = 0,
                    RCO_Fee = 1000,
                    CRC_Remarks = "",
                    User_Name = "Mudasir Ashraf",
                    Create_Date = DateTime.Parse(DateTime.Today.ToString()),
                    Create_Time =DateTime.Parse(DateTime.Today.ToString()),
                },
            };
        }
    }
}
