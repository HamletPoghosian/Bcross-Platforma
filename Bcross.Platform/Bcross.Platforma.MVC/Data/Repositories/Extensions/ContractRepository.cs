using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Bcross.Platforma.MVC.Models.AppDBContext;
using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data.Repositories.Extensions
{
    public class ContractRepository : IContractRepository
    {
        private readonly BcrossContext _context;

        public ContractRepository(BcrossContext context)
        {
            _context = context;
        }
        public async Task<Contract> CreateContract(Contract contract)
        {
            if (contract == null)
                return null;

              await _context.Contract.AddAsync(contract);
              await _context.SaveChangesAsync();
              return null;
        }

        public Task<List<Contract>> GetAllContracts()
        {
            throw new NotImplementedException();
        }

        public Task<List<Contract>> GetContractByFirstCompanyIds(List<long> companyIds)
        {
            throw new NotImplementedException();
        }

        public Task<Contract> GetContractById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contract>> GetContractBySecoundCompanyIds(List<long> companyIds)
        {
            throw new NotImplementedException();
        }
    }
}
