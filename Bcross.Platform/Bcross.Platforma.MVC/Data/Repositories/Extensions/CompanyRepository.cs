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
            var compies = await _context.Company
                .AsNoTracking()
                .ToListAsync();
            return compies;
        }

        public async Task<Company> GetCompanyById(long id)
        {
            if (id == 0)
            {
                return null;
            }

           var company = await _context.Company.Where(c => c.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return company;
        }

        public async Task<List<Company>> GetCompanyByIds(List<long> companyIds)
        {
            if (companyIds.Count== 0)
            {
                return null;
            }

            var company = await _context.Company.Where(c => companyIds.Contains(c.Id))
                .AsNoTracking()
                .ToListAsync();

            return company.Count == 0 ? null : company;
        }

        public async Task<Company> GetCompanyByName(string companyName)
        {
            if (string.IsNullOrEmpty(companyName))
            {
                return null;
            }

            var company = await _context.Company.Where(c => c.Name.Contains(companyName))
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return company;
        }

        public async Task<Company> GetCompanyByCountryCode(string companyCode)
        {
            if (string.IsNullOrEmpty(companyCode))
            {
                return null;
            }

            var company = await _context.Company.Where(c => c.CountryCode.Contains(companyCode))
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return company;
        }

        public async Task<Company> CreateCompany(Company company)
        {
            if (company == null)
                return null;

            await _context.AddAsync(company);
            await _context.SaveChangesAsync();

            var companyDB = await GetCompanyByName(company.Name);
            return companyDB;
        }

        public async Task<Company> UpdateCompany(Company company)
        {
            if (company == null)
                return null;

            var existingCompany = await _context.Company.Where(c => c.Id == company.Id).FirstOrDefaultAsync();
           
            if (existingCompany != null)
            {
                existingCompany.City = company.City;
                existingCompany.Code = company.Code;
                existingCompany.Country = company.Country;
                existingCompany.CountryCode = company.CountryCode;
                existingCompany.Email = company.Email;
                existingCompany.AddressLine = company.AddressLine;
                existingCompany.LogoUrl = company.LogoUrl;
                existingCompany.Name = company.Name;
                existingCompany.Phone = company.Phone;
                existingCompany.RegistrationNumber = company.RegistrationNumber;
                existingCompany.Remarks = company.Remarks;
                existingCompany.StateCode = company.StateCode;
                existingCompany.Zip = company.Zip;

                _context.Update(existingCompany);
                await _context.SaveChangesAsync();

                return existingCompany;
            }

            return null;
        }

        public async void DeleteCompanyByName(string companyName)
        {

            if (string.IsNullOrEmpty(companyName))
                return ;

            var existingCompany = await _context.Company.Where(c => c.Name == companyName ).FirstOrDefaultAsync();
           
            _context.Remove(existingCompany);
            await _context.SaveChangesAsync();

        }

        public async void DeleteCompanyById(long companyId)
        {
            if (companyId < 1) 
                return;

            var existingCompany = await _context.Company.Where(c => c.Id == companyId).FirstOrDefaultAsync();

            _context.Remove(existingCompany);
            await _context.SaveChangesAsync();
        }
    }
}
