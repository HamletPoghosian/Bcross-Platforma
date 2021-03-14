using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Bcross.Platforma.MVC.Data.Services.Interfaces;
using Bcross.Platforma.MVC.Models.Company;
using Bcross.Platforma.MVC.Models.DataTransferObjects.Companies;
using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Bcross.Platforma.MVC.Data.Services.Extensions
{
    public class StatisticRepository : IStatisticService
    {
        public Task<RatingDTO> AddRating(long companyId, RatingDTO rating)
        {
            throw new NotImplementedException();
        }

        public Task<List<CompanyDTO>> GetAllSuccessCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<List<CompanyDTO>> GetAllSuccessCompaniesByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public Task<List<CompanyDTO>> GetAllSuccessCompaniesByRating(int rating)
        {
            throw new NotImplementedException();
        }

        public Task<RatingDTO> GetRating(long companyId)
        {
            throw new NotImplementedException();
        }

        public Task<RatingDTO> UpdateRating(long companyId, RatingDTO rating)
        {
            throw new NotImplementedException();
        }
    }
}
