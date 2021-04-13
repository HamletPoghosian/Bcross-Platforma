using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
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
        private readonly IContractRepository _contractRepository;

        public ContractService(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
        }

        public async Task<ContractDTO> CreateContractAsync(ContractDTO company)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContractDTO>> GetAllContractsAsync()
        {
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
