using Bcross.Platforma.MVC.Models.Company;
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
                });

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
            };


            return companyDTO;
        }
    }
}
