using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Bcross.Platforma.Application.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bcross.Platform.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Company : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Companies()
        {
            var companies = new CompanyDto();
            if (companies == null)
                return NotFound();

            return Ok("Welcome Bcross");
        }


        [HttpPost]
        [Route("Companies")]
        [ProducesResponseType(typeof(CompanyDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Companies([FromBody] long id)
        {
            var companies = new CompanyDto();
            if (companies == null)
                return NotFound();

            return Ok(companies);
        }


        [HttpPost]
        [Route("allCompanies")]
        [ProducesResponseType(typeof(CompanyDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> AllCompanies([FromBody] List<long> ids)
        {
            var companies = new CompanyDto();
            if (companies == null)
                return NotFound();

            return Ok(companies);
        }

    }
}