using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Models.DbModels
{
    public class Rating
    {
        [Key]
        [Column("rating_id")]
        public long RatingId { get; set; }

        public long VotingCount { get; set; }

        public long VotingValue { get; set; }

        public DateTime UpdatedDate { get; set; }

        public List<Company> Companies { get; set; }

    }
}
