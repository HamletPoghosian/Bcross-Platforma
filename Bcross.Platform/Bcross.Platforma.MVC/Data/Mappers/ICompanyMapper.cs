using Bcross.Platforma.MVC.Models.Company;
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
    }
}
