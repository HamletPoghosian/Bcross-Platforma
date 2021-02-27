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

        public List<CompanyDTO> ToCompanyDTO(List<Company> companyDTOs)
        {
            List<CompanyDTO> companyDTO = new List<CompanyDTO>();
            return companyDTO;
        }
    }
}
