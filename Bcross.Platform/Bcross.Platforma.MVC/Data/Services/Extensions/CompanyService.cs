using Bcross.Platforma.MVC.Data.Mappers;
using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Bcross.Platforma.MVC.Data.Services.Interfaces;
using Bcross.Platforma.MVC.Models.Company;
using Bcross.Platforma.MVC.Models.DbModels;
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
            if (string.IsNullOrEmpty(companyCode))
                return null;

            var company = await _companyRepository.GetCompanyByCountryCode(companyCode);
            var companyDTO = _companyMapper.ToCompanyDTO(company);
            return companyDTO;
        }

        public async Task<CompanyDTO> GetCompanyByIdAsync(long id)
        {
            if (id < 1) 
                return null;

            var company = await _companyRepository.GetCompanyById(id);
            var companyDTO = _companyMapper.ToCompanyDTO(company);
            return companyDTO;
        }

        public async Task<List<CompanyDTO>> GetCompanyByIdsAsync(List<long> companyIds)
        {
            if (companyIds == null || companyIds.Count < 1) 
                return null;

            var companies = await _companyRepository.GetCompanyByIds(companyIds);
            var companyDTO = _companyMapper.ToCompanyDTO(companies);
            return companyDTO;
        }

        public async Task<CompanyDTO> GetCompanyByNameAsync(string companyName)
        {
            if (string.IsNullOrEmpty(companyName))
                return null;
            var company = await _companyRepository.GetCompanyByName(companyName);
            var companyDTO = _companyMapper.ToCompanyDTO(company);
            return companyDTO;
        }

        public async Task<CompanyDTO> UpdateCompanyAsync(CompanyDTO companyDTO)
        {
            if (companyDTO == null)
                return null;
            
            var companyDB = _companyMapper.ToCompanyDB(companyDTO);

            var company = await _companyRepository.UpdateCompany(companyDB);

            return _companyMapper.ToCompanyDTO(company);
        }

        public async Task<CompanyDTO> CreateCompanyAsync(CompanyDTO companyDTO)
        {
            if (companyDTO == null)
                return null;

            var companyDB = _companyMapper.ToCompanyDB(companyDTO);

            var company = await _companyRepository.CreateCompany(companyDB);

            return _companyMapper.ToCompanyDTO(company);

        }

        public void DeleteCompanyByIdAsync(long companyId)
        {
            if (companyId < 1)
                return;

            throw new NotImplementedException();
        }

        public void DeleteCompanyByNameAsync(string companyName)
        {
            if (string.IsNullOrEmpty(companyName))
                return;

            throw new NotImplementedException();
        }
    }
}
