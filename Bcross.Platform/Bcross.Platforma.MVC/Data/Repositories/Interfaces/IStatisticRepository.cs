using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Repositories.Interfaces
{
    public interface IStatisticRepository
    {
        Task<List<Company>> GetAllSuccessCompanies();
        Task<List<Company>> GetAllSuccessCompaniesByRating(int rating);
        Task<List<Company>> GetAllSuccessCompaniesByCountry(string countryName);
        Task<Rating> AddRating(long companyId, Rating rating);
        Task<Rating> GetRating(long companyId);
        Task<Rating> UpdateRating(long companyId, Rating rating);
    }
}
