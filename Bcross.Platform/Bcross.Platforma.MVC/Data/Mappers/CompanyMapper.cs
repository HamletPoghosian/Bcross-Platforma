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
        public CompanyMapper()
        {

        }      

        public List<CompanyDTO> ToCompanyDTO(List<Company> companies)
        {
            if (companies == null || companies.Count == 0)
                return null;

            List<CompanyDTO> companyDTO = new List<CompanyDTO>();

            foreach (var company in companies)
            {
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
                        RatingId = company.Rating.RatingId,
                        VotingCount = company.Rating.VotingCount,
                        VotingValue = company.Rating.VotingValue

                    }
                }) ;

            }
            return companyDTO;
        }

        public CompanyDTO ToCompanyDTO(Company company)
        {
            if (company == null)
                return null;

            CompanyDTO companyDTO;

            companyDTO = new CompanyDTO
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
                    RatingId = company.Rating.RatingId,
                    VotingCount = company.Rating.VotingCount,
                    VotingValue = company.Rating.VotingValue

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
                RatingId=companyDTO.Rating.RatingId
            };


            return companyDB;
        }
    }
}
