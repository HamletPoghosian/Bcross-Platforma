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
        public Task<Contract> CreateContract(Contract company)
        {
            throw new NotImplementedException();
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
