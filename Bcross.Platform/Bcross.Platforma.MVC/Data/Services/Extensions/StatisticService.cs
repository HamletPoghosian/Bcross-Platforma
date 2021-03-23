using Bcross.Platforma.MVC.Data.Mappers;
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
    public class StatisticService : IStatisticService
    {
        private readonly IStatisticRepository _statisticRepository;
        private readonly ICompanyMapper _companyMapper;

        public StatisticService(IStatisticRepository statisticRepository, ICompanyMapper companyMapper)
        {
            _statisticRepository = statisticRepository;
            _companyMapper = companyMapper;
        }

        public async Task<RatingDTO> AddRating(long companyId, RatingDTO rating)
        {
            if (companyId > 0 && rating != null)
            {
                var ratingDB = _companyMapper.ToRating(rating);
                var result = await _statisticRepository.AddRating(companyId, ratingDB);
                var ratingDTO = _companyMapper.ToRatingDTO(result);

                return ratingDTO;
            }
            return null;
        }

        public async Task<List<CompanyDTO>> GetAllSuccessCompanies()
        {
            var companies = await _statisticRepository.GetAllSuccessCompanies();
            var companiesDTO = await _companyMapper.ToCompanyDTO(companies);
            return companiesDTO;
        }

        public async Task<List<CompanyDTO>> GetAllSuccessCompaniesByCountry(string countryName)
        {
            var companies = await _statisticRepository.GetAllSuccessCompaniesByCountry(countryName);
            var companiesDTO = await _companyMapper.ToCompanyDTO(companies);
            return companiesDTO;
        }

        public async Task<List<CompanyDTO>> GetAllSuccessCompaniesByRating(int rating)
        {
            var companies = await _statisticRepository.GetAllSuccessCompaniesByRating(rating);
            var companiesDTO = await _companyMapper.ToCompanyDTO(companies);
            return companiesDTO;
        }

        public async Task<RatingDTO> GetRating(long companyId)
        {
            var  rating = await _statisticRepository.GetRating(companyId);
            var ratingDTO = _companyMapper.ToRatingDTO(rating);
            return ratingDTO;
        }

        public async Task<RatingDTO> UpdateRating(long companyId, RatingDTO ratingDTO)
        {
            if (ratingDTO != null && companyId > 0)
            {
                var rating = _companyMapper.ToRating(ratingDTO);

                var ratingDB = await _statisticRepository.UpdateRating(companyId, rating);

                return _companyMapper.ToRatingDTO(ratingDB);
            }
            return null;
        }
    }
}
