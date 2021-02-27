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

        public async Task<Company> GetCompanyById(long id)
        {
            if (id == 0)
            {
                return null;
            }

           var company = await _context.Company.Where(c => c.Id == id).FirstOrDefaultAsync();

            return company;
        }

        public async Task<List<Company>> GetCompanyByIds(List<long> companyIds)
        {
            if (companyIds.Count== 0)
            {
                return null;
            }

            var company = await _context.Company.Where(c => companyIds.Contains(c.Id)).ToListAsync();

            return company.Count == 0 ? null : company;
        }

        public async Task<Company> GetCompanyByName(string companyName)
        {
            if (string.IsNullOrEmpty(companyName))
            {
                return null;
            }

            var company = await _context.Company.Where(c => c.Name.Contains(companyName)).FirstOrDefaultAsync();

            return company;
        }

        public async Task<Company> GetCompanyByCountryCode(string companyCode)
        {
            if (string.IsNullOrEmpty(companyCode))
            {
                return null;
            }

            var company = await _context.Company.Where(c => c.CountryCode.Contains(companyCode)).FirstOrDefaultAsync();

            return company;
        }

    }
}
