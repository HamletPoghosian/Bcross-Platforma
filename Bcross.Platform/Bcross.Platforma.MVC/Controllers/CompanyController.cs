using Bcross.Platforma.MVC.Data.Services.Interfaces;
using Bcross.Platforma.MVC.Models.Company;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        // GET: Company
        public async Task<ActionResult> Index()
        
        
        {
            var companyDTOs = await _companyService.GetAllCompaniesAsync();

            return View(companyDTOs);
        }

        // GET: Company/Details/5
        public async Task<ActionResult> GetCompanyById(int id)
        {
            var company = await _companyService.GetCompanyByIdAsync(id);

            return View(company);
        }

        public async Task<ActionResult<CompanyDTO>> GetCompany(CompanyDTO  companyDTO)
        {
            var company = await _companyService.GetCompanyByNameAsync(companyDTO.Name);

            return View(company);
        }

        public async Task<ActionResult<List<CompanyDTO>>> GetAllCompanies()
        {
            var companyDTOs = await _companyService.GetAllCompaniesAsync();

            return View(companyDTOs);
        }

        public ActionResult<List<CompanyDTO>> SearchCompanies()
        {
            return View();
        }

        // GET: Company/Create 
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CompanyDTO companyDTO)
        {
            try
            {
                var companyDTOs = await _companyService.CreateCompanyAsync(companyDTO);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Company/Edit/5
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

        // GET: Company/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            await _companyService.DeleteCompanyByIdAsync(id);

            return View();
        }

        // POST: Company/Delete/5
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
