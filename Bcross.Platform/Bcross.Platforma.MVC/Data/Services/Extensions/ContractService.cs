using Bcross.Platforma.MVC.Data.Services.Interfaces;
using Bcross.Platforma.MVC.Models.DataTransferObjects.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Services.Extensions
{
    public class ContractService : IContractService
    {
        public Task<ContractDTO> CreateContractAsync(ContractDTO company)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContractDTO>> GetAllContractsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ContractDTO>> GetContractByFirstCompanyIdsAsync(List<long> companyIds)
        {
            throw new NotImplementedException();
        }

        public Task<ContractDTO> GetContractByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContractDTO>> GetContractBySecoundCompanyIdsAsync(List<long> companyIds)
        {
            throw new NotImplementedException();
        }
    }
}
