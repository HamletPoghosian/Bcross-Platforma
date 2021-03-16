using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Bcross.Platforma.MVC.Models.AppDBContext;
using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Repositories.Extensions
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly BcrossContext _context;

        public StatisticRepository(BcrossContext context)
        {
            _context = context;
        }
        public Task<Rating> AddRating(long companyId, Rating rating)
        {
            throw new NotImplementedException();
        }

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

        public Task<Rating> GetRating(long companyId)
        {
            throw new NotImplementedException();
        }

        public Task<Rating> UpdateRating(long companyId, Rating rating)
        {
            throw new NotImplementedException();
        }
    }
}
