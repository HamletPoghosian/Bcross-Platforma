using Bcross.Platforma.MVC.Models.DataTransferObjects.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Services.Interfaces
{
    public interface IContractService
    {
        Task<List<ContractDTO>> GetAllContractsAsync();
        Task<ContractDTO> GetContractByIdAsync(long id);
        Task<List<ContractDTO>> GetContractByFirstCompanyIdsAsync(List<long> companyIds);
        Task<List<ContractDTO>> GetContractBySecoundCompanyIdsAsync(List<long> companyIds);
        Task<ContractDTO> CreateContractAsync(ContractDTO company);
        Task<ContractDTO> UpdateContractAsync(long id ,ContractDTO company);

    }
}
