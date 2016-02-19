using ND.BO;
using ND.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ND.MonitorDasboard.Web.Areas.Monitoring.Controllers
{
    public class MonitorController : Controller
    {
        // GET: Monitoring/Monitor
        public ActionResult Index()
        {
            //IList<MonitorResultBO> model = MonitorService.GetAllPaging(0, 10);
            //return View(model);
            return View();
        }

        // GET: Monitoring/Monitor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Monitoring/Monitor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Monitoring/Monitor/Create
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

        // GET: Monitoring/Monitor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Monitoring/Monitor/Edit/5
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

        // GET: Monitoring/Monitor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Monitoring/Monitor/Delete/5
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
