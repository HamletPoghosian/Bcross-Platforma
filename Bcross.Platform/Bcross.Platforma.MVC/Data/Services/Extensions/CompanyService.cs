using Bcross.Platforma.MVC.Data.Mappers;
using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Bcross.Platforma.MVC.Data.Services.Interfaces;
using Bcross.Platforma.MVC.Models.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Services.Extensions
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ICompanyMapper  _companyMapper;

        public CompanyService(ICompanyRepository companyRepository, ICompanyMapper companyMapper)
        {
            _companyRepository = companyRepository;
            _companyMapper = companyMapper;
        }
        public async Task<List<CompanyDTO>> GetAllCompaniesAsync()
        {
            var companies = await _companyRepository.GetAllCompanies();
           var companyDTOs = _companyMapper.ToCompanyDTO(companies);
            return companyDTOs;
        }

        public async Task<CompanyDTO> GetCompanyByCountryCodeAsync(string companyCode)
        {
            throw new NotImplementedException();
        }

        public async Task<CompanyDTO> GetCompanyByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CompanyDTO>> GetCompanyByIdsAsync(List<long> companyIds)
        {
            throw new NotImplementedException();
        }

        public async Task<CompanyDTO> GetCompanyByNameAsync(string companyName)
        {
            throw new NotImplementedException();
        }
    }
}
