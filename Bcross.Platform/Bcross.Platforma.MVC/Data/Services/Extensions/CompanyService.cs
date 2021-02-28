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
            var company = await _companyRepository.GetCompanyByCountryCode(companyCode);
            var companyDTO = _companyMapper.ToCompanyDTO(company);
            return companyDTO;
        }

        public async Task<CompanyDTO> GetCompanyByIdAsync(long id)
        {
            var company = await _companyRepository.GetCompanyById(id);
            var companyDTO = _companyMapper.ToCompanyDTO(company);
            return companyDTO;
        }

        public async Task<List<CompanyDTO>> GetCompanyByIdsAsync(List<long> companyIds)
        {
            var companies = await _companyRepository.GetCompanyByIds(companyIds);
            var companyDTO = _companyMapper.ToCompanyDTO(companies);
            return companyDTO;
        }

        public async Task<CompanyDTO> GetCompanyByNameAsync(string companyName)
        {
            var company = await _companyRepository.GetCompanyByName(companyName);
            var companyDTO = _companyMapper.ToCompanyDTO(company);
            return companyDTO;
        }

        public Task<CompanyDTO> UpdateCompany(Models.DbModels.Company company)
        {
            throw new NotImplementedException();
        }

        public void CreateCompany(CompanyDTO company)
        {
            throw new NotImplementedException();
        }

        public void DeleteCompanyById(long companyId)
        {
            throw new NotImplementedException();
        }

        public void DeleteCompanyByName(string companyName)
        {
            throw new NotImplementedException();
        }
    }
}
