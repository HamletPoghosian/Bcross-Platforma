using Bcross.Platforma.MVC.Data.Mappers;
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
        private readonly ICompanyMapper _companyMapper;

        public ContractService(IContractRepository contractRepository, ICompanyMapper companyMapper)
        {
            _contractRepository = contractRepository;
            _companyMapper = companyMapper;
        }

        public async Task<ContractDTO> CreateContractAsync(ContractDTO contract)
        {
            if (contract == null)
                return null;

            var contractDB = _companyMapper.ToContract(contract);

            var newcontractDB = await _contractRepository.CreateContract(contractDB);

            var contractDTO = _companyMapper.ToContractDTO(newcontractDB);

            return contractDTO;

        }

        public async Task<List<ContractDTO>> GetAllContractsAsync()
        {
            var contracts = await _contractRepository.GetAllContracts();
            var contractsDTO = _companyMapper.ToContractDTO(contracts);
            return contractsDTO;
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
