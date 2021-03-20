using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Bcross.Platforma.MVC.Models.AppDBContext;
using Bcross.Platforma.MVC.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Repositories.Extensions
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly BcrossContext _context;
        private readonly ICompanyRepository _companyRepository;

        public StatisticRepository(BcrossContext context, ICompanyRepository companyRepository)
        {
            _context = context;
            _companyRepository = companyRepository;
        }
        public async Task<Rating> AddRating(long companyId, Rating rating)
        {
            var company = _context.Company.Where(c => c.Id == companyId).FirstOrDefault();
            company.Rating = rating;

            await _context.SaveChangesAsync();

            return company.Rating;
        }

        public async Task<List<Company>> GetAllSuccessCompanies()
        {
            var successCompany = await _context.Company.Join(_context.Rating,
                c => c.RatingId,
                r => r.RatingId,
                (c, r) => new { company = c, rating = r })
                .Where(cca => cca.company.RatingId == cca.rating.RatingId && cca.rating.VotingValue > 8)
                .Select(ssa => ssa.company)
                .AsNoTracking()
                .ToListAsync();
                          
            return successCompany;

        }

        public async  Task<List<Company>> GetAllSuccessCompaniesByCountry(string countryName)
        {
            var successCompany = await _context.Company.Join(_context.Rating,
                s => s.RatingId,
                ss => ss.RatingId,
                (s, ss) => new { company = s, rating = ss })
                .Where(ssa => ssa.rating.RatingId == ssa.rating.RatingId && ssa.company.Country== countryName)
                .Select(ssa => ssa.company)
                .AsNoTracking()
                .ToListAsync();

            return successCompany;
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
