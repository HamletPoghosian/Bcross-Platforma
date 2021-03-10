using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Models.DataTransferObjects.Companies
{
    public class ContractDTO
    {
        public long Id { get; set; }

        public long Price { get; set; }

        public long FirstCompanyId { get; set; }

        public long SecondCompanyId { get; set; }

        public DateTime StartDay { get; set; }

        public DateTime FinishDay { get; set; }
    }
}
