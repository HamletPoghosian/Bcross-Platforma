using Bcross.Platforma.MVC.Models.Company;
using Bcross.Platforma.MVC.Models.DataTransferObjects.Companies;
using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Services.Interfaces
{
    public interface IStatisticService
    {
        Task<List<CompanyDTO>> GetAllSuccessCompanies();
        Task<List<CompanyDTO>> GetAllSuccessCompaniesByRating(int rating);
        Task<List<CompanyDTO>> GetAllSuccessCompaniesByCountry(string countryName);
        Task<RatingDTO> AddRating(long companyId, RatingDTO rating);
        Task<RatingDTO> GetRating(long companyId);
        Task<RatingDTO> UpdateRating(long companyId, RatingDTO rating);
    }
}
