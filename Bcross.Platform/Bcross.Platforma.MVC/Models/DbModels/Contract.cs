using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Models.DbModels
{
    public class Contract
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("Price")]
        public long Price { get; set; }

        [Column("first_company_id")]
        public long FirstCompanyId { get; set; }
        
        [Column("second_company_id")]
        public long SecondCompanyId { get; set; }

        [Column("start_day")]
        public DateTime StartDay { get; set; }

        [Column("finish_day")]
        public DateTime FinishDay { get; set; }
    }
}
