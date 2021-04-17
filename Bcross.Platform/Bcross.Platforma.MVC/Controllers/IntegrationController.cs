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
    public class IntegrationController : Controller
    {
        private readonly IContractService _companyService;


        public IntegrationController(IContractService companyService)
        {
            _companyService = companyService;
        }

        // GET: IntegrationController
        public async Task<ActionResult> Index()
        {
            var contractDTOs = await _companyService.GetAllContractsAsync();
            return View(contractDTOs);
        }

        // GET: IntegrationController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var contractDTOs = await _companyService.GetContractByIdAsync(id);

            return View(contractDTOs);
        }

        // GET: IntegrationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IntegrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ContractDTO contract)
        {
            try
            {
                var contractDTOs = await _companyService.CreateContractAsync(contract);

                return RedirectToAction(nameof(Index), contractDTOs);
            }
            catch
            {
                return View();
            }
        }

        // GET: IntegrationController/Edit/5
        public async Task<ActionResult> Edit(int id , ContractDTO contract)
        {
            var contractDTOs = await _companyService.UpdateContractAsync(id, contract);

            return View(contractDTOs);
        }

        // POST: IntegrationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async ActionResult Edit(List<ContractDTO> contracts)
        {
            try
            {
                foreach (var item in contracts)
                {
                var contractDTOs = await _companyService.UpdateContractAsync(id, item);

                }
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
