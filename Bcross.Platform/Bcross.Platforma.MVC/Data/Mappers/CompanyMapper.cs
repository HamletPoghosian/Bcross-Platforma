using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Bcross.Platforma.MVC.Models.Company;
using Bcross.Platforma.MVC.Models.DataTransferObjects.Companies;
using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Mappers
{
    public class CompanyMapper: ICompanyMapper
    {
        private readonly IStatisticRepository _statisticRepository;

        public CompanyMapper(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }      

        public async Task<List<CompanyDTO>> ToCompanyDTO(List<Company> companies)
        {
            if (companies == null || companies.Count == 0)
                return null;

            List<CompanyDTO> companyDTO = new List<CompanyDTO>();

            foreach (var company in companies)
            {
                var rating = await _statisticRepository.GetRating(company.Id);

                companyDTO.Add(new CompanyDTO
                {
                    Id = company.Id,
                    City = company.City,
                    Code = company.Code,
                    Country = company.Country,
                    CountryCode = company.CountryCode,
                    Email = company.Email,
                    Line = company.AddressLine,
                    LogoUrl = company.LogoUrl,
                    Name = company.Name,
                    Phone = company.Phone,
                    RegistrationNumber = company.RegistrationNumber,
                    Remarks = company.Remarks,
                    StateCode = company.StateCode,
                    Zip = company.Zip,
                    Rating = new RatingDTO
                    {
                        RatingId = rating.RatingId,
                        VotingCount = rating.VotingCount,
                        VotingValue = rating.VotingValue

                    }
                }) ;

            }
            return companyDTO;
        }

        public async Task<CompanyDTO> ToCompanyDTO(Company company)
        {
            if (company == null)
                return null;

            var rating = await _statisticRepository.GetRating(company.Id);

            var companyDTO = new CompanyDTO
            {
                Id = company.Id,
                City = company.City,
                Code = company.Code,
                Country = company.Country,
                CountryCode = company.CountryCode,
                Email = company.Email,
                Line = company.AddressLine,
                LogoUrl = company.LogoUrl,
                Name = company.Name,
                Phone = company.Phone,
                RegistrationNumber = company.RegistrationNumber,
                Remarks = company.Remarks,
                StateCode = company.StateCode,
                Zip = company.Zip,
                Rating = new RatingDTO
                {
                    RatingId = rating.RatingId,
                    VotingCount = rating.VotingCount,
                    VotingValue = rating.VotingValue

                }
            };


            return companyDTO;
        }

        public List<Company> ToCompanyDB(List<CompanyDTO> companies)
        {
            if (companies == null || companies.Count == 0)
                return null;

            List<Company> companyDB = new List<Company>();

            foreach (var company in companies)
            {
                companyDB.Add(new Company
                {
                    Id = company.Id,
                    City = company.City,
                    Code = company.Code,
                    Country = company.Country,
                    CountryCode = company.CountryCode,
                    Email = company.Email,
                    AddressLine = company.Line,
                    LogoUrl = company.LogoUrl,
                    Name = company.Name,
                    Phone = company.Phone,
                    RegistrationNumber = company.RegistrationNumber,
                    Remarks = company.Remarks,
                    StateCode = company.StateCode,
                    Zip = company.Zip,
                    RatingId=company.Rating.RatingId
                });
            }

            return companyDB;
        }

        public Company ToCompanyDB(CompanyDTO companyDTO)
        {
            if (companyDTO == null)
                return null;

            Company companyDB;
            Rating ratingDB;

            ratingDB = new Rating
            {
                UpdatedDate = companyDTO.Rating.UpdatedDate,
                VotingValue = companyDTO.Rating.VotingValue,
                VotingCount = companyDTO.Rating.VotingCount

            };



            companyDB = new Company
            {
                Id = companyDTO.Id,
                City = companyDTO.City,
                Code = companyDTO.Code,
                Country = companyDTO.Country,
                CountryCode = companyDTO.CountryCode,
                Email = companyDTO.Email,
                AddressLine = companyDTO.Line,
                LogoUrl = companyDTO.LogoUrl,
                Name = companyDTO.Name,
                Phone = companyDTO.Phone,
                RegistrationNumber = companyDTO.RegistrationNumber,
                Remarks = companyDTO.Remarks,
                StateCode = companyDTO.StateCode,
                Zip = companyDTO.Zip,
                Rating = ratingDB
            };


            return companyDB;
        }

        public RatingDTO ToRatingDTO(Rating rating)
        {
            if (rating != null)
            {
                return new RatingDTO()
                {
                    RatingId = rating.RatingId,
                    UpdatedDate = rating.UpdatedDate,
                    VotingCount = rating.VotingCount,
                    VotingValue = rating.VotingValue
                };
            }
            return null;
        }

        public Rating ToRating(RatingDTO rating)
        {
            if (rating != null)
            {
                return new Rating()
                {
                    RatingId = rating.RatingId,
                    UpdatedDate = rating.UpdatedDate,
                    VotingCount = rating.VotingCount,
                    VotingValue = rating.VotingValue
                };
            }
            return null;
        }

        public List<RatingDTO> ToRatingDTO(List<Rating> ratings)
        {

            if (ratings == null || ratings.Count == 0)
                return null;

            List<RatingDTO> ratingDB = new List<RatingDTO>();

            foreach (var rating in ratings)
            {
                ratingDB.Add(new RatingDTO
                {
                    RatingId = rating.RatingId,
                    UpdatedDate= rating.UpdatedDate,
                     VotingCount= rating.VotingCount,
                     VotingValue=rating.VotingValue

                });
            }

            return ratingDB;
        }

        public List<Rating> ToRating(List<RatingDTO> ratings)
        {
            if (ratings == null || ratings.Count == 0)
                return null;

            List<Rating> ratingDB = new List<Rating>();

            foreach (var rating in ratings)
            {
                ratingDB.Add(new Rating
                {
                    RatingId = rating.RatingId,
                    UpdatedDate = rating.UpdatedDate,
                    VotingCount = rating.VotingCount,
                    VotingValue = rating.VotingValue

                });
            }

            return ratingDB;
        }

        public List<Contract> ToContract(List<ContractDTO>  contracts)
        {
            if (contracts == null || contracts.Count == 0)
                return null;

            List<Contract> contractDB = new List<Contract>();

            foreach (var  contract in contracts)
            {
                contractDB.Add(new Contract
                {
                  FirstCompanyId=contract.FirstCompanyId,
                  SecondCompanyId=contract.SecondCompanyId,
                  Price=contract.Price,
                  StartDay=contract.StartDay,
                  FinishDay=contract.FinishDay
                });
            }

            return contractDB;
        }

        public List<ContractDTO> ToContractDTO(List<Contract> contracts)
        {
            if (contracts == null || contracts.Count == 0)
                return null;

            List<ContractDTO> contractDTO = new List<ContractDTO>();

            foreach (var contract in contracts)
            {
                contractDTO.Add(new ContractDTO
                {
                    FirstCompanyId = contract.FirstCompanyId,
                    SecondCompanyId = contract.SecondCompanyId,
                    Price = contract.Price,
                    StartDay = contract.StartDay,
                    FinishDay = contract.FinishDay
                });
            }

            return contractDTO;
        }

        public Contract ToContract(ContractDTO contract)
        {
            if (contract != null)
            {
                return new Contract()
                {
                    FirstCompanyId = contract.FirstCompanyId,
                    SecondCompanyId = contract.SecondCompanyId,
                    Price = contract.Price,
                    StartDay = contract.StartDay,
                    FinishDay = contract.FinishDay
                };
            }

            return null;
        }

        public ContractDTO ToContractDTO(Contract contract)
        {

        }
    }
}
