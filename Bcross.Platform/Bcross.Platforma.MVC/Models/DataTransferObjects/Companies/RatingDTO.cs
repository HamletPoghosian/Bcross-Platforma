using Bcross.Platforma.MVC.Models.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Models.DataTransferObjects.Companies
{
    public class RatingDTO
    {
        public long RatingId { get; set; }

        public long VotingCount { get; set; }

        public long VotingValue { get; set; }

        public DateTime UpdatedDate { get; set; }

    }
}
