using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Controllers
{
    public class IntegrationController : Controller

    {
        // GET: IntegrationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: IntegrationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IntegrationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IntegrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IntegrationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IntegrationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IntegrationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IntegrationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
