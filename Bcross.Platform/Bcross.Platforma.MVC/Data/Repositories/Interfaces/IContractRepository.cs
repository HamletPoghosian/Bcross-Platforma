using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Repositories.Interfaces
{
    public interface IContractRepository
    {
        Task<List<Contract>> GetAllContracts();
        Task<Contract> GetContractById(long id);
        Task<List<Contract>> GetContractByFirstCompanyIds(List<long> companyIds);
        Task<List<Contract>> GetContractBySecoundCompanyIds(List<long> companyIds);
        Task<Contract> CreateContract(Contract company);
    }
}
