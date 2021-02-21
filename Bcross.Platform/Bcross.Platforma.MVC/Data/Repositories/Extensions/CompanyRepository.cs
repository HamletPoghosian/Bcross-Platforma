using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Bcross.Platforma.MVC.Models.AppDBContext;
using Bcross.Platforma.MVC.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly BcrossContext _context;

        public CompanyRepository(BcrossContext context)
        {
            _context = context;
        }

        public async Task<List<Company>> GetAllCompanies()
        {
            var compies = await _context.Company.ToListAsync();
            return compies;
        }
    }
}
