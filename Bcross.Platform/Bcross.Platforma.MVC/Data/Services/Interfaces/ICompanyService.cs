using Bcross.Platforma.MVC.Models.Company;
using Bcross.Platforma.MVC.Models.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Services.Interfaces
{
    public interface ICompanyService
    {
        Task<List<CompanyDTO>> GetAllCompaniesAsync();
        Task<CompanyDTO> GetCompanyByIdAsync(long id);
        Task<CompanyDTO> GetCompanyByNameAsync(string companyName);
        Task<List<CompanyDTO>> GetCompanyByIdsAsync(List<long> companyIds);
        Task<CompanyDTO> GetCompanyByCountryCodeAsync(string companyCode);
        void CreateCompany(CompanyDTO company);
        Task<CompanyDTO> UpdateCompany(Company company);
        void DeleteCompanyByName(string companyName);
        void DeleteCompanyById(long companyId);
    }
}
