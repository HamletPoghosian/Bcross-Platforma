using Bcross.Platforma.MVC.Data.Services.Interfaces;
using Bcross.Platforma.MVC.Models.DataTransferObjects.Companies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        // GET: StatisticController
        public async Task<ActionResult> Index()
        {
            var companyDTOs = await _statisticService.GetAllSuccessCompanies();
            return View(companyDTOs);
        }

        // GET: StatisticController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var companyDTOs = await _statisticService.GetAllSuccessCompaniesByRating(id);

            return View(companyDTOs);
        }

        // GET: StatisticController/Details/5
        public async Task<ActionResult> GetByCompaniesByCountry(string countryCode)
        {
            var companyDTOs = await _statisticService.GetAllSuccessCompaniesByCountry(countryCode);

            return View(companyDTOs);
        }

        // GET: StatisticController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatisticController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(long companyID, RatingDTO ratingDTO)
        {
            try
            {
                var companyDTOs = await _statisticService.AddRating(companyID, ratingDTO);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StatisticController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StatisticController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, RatingDTO ratingDTO)
        {
            try
            {
                var companyDTOs = await _statisticService.UpdateRating(id, ratingDTO);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StatisticController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StatisticController/Delete/5
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

        [HttpGet]
        public async Task<ActionResult> GetReting(int companyId)
        {
            var companyDTOs = await _statisticService.GetRating(companyId);

            return View(companyDTOs);
        }
    }
}
