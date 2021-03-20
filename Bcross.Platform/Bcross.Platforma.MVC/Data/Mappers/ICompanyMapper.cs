using Bcross.Platforma.MVC.Models.Company;
using Bcross.Platforma.MVC.Models.DataTransferObjects.Companies;
using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Mappers
{
    public interface ICompanyMapper
    {
        List<CompanyDTO> ToCompanyDTO(List<Company> company);
        CompanyDTO ToCompanyDTO(Company company);
        List<Company> ToCompanyDB(List<CompanyDTO> company);
        Company ToCompanyDB(CompanyDTO company);
        RatingDTO ToRatingDTO(Rating company);
        Rating ToRating(RatingDTO company);
    }
}
