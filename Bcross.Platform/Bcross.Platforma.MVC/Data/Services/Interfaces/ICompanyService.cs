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
        Task<CompanyDTO> CreateCompanyAsync(CompanyDTO company);
        Task<CompanyDTO> UpdateCompanyAsync(CompanyDTO company);
        void DeleteCompanyByNameAsync(string companyName);
        void DeleteCompanyByIdAsync(long companyId);
    }
}
