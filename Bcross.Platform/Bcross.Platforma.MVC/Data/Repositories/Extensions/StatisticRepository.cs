using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Repositories.Extensions
{
    public class StatisticRepository : IStatisticRepository
    {
        public Task<List<Company>> GetAllSuccessCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllSuccessCompaniesByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllSuccessCompaniesByRating(int rating)
        {
            throw new NotImplementedException();
        }
    }
}
