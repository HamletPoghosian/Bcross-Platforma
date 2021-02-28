using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Repositories.Interfaces
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllCompanies();
        Task<Company> GetCompanyById(long id);
        Task<Company> GetCompanyByName(string companyName);
        Task<List<Company>> GetCompanyByIds(List<long> companyIds);
        Task<Company> GetCompanyByCountryCode(string companyCode);
        Task<Company> CreateCompany(Company company);
        Task<Company> UpdateCompany(Company company);
        Task<Company> DeleteCompany(Company company);
        Task<Company> DeleteCompanyById(long companyId);
    }
}
