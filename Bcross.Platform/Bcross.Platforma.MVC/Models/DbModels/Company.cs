using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Models.DbModels
{
    public class Company
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("country")]
        public string Country { get; set; }

        [Column("country_code")] 
        public string CountryCode { get; set; }

        [Column("state_code")]
        public string StateCode { get; set; }
      
        [Column("city")]
        public string City { get; set; }

        [Column("zip")]
        public string Zip { get; set; }

        [Column("address_line")]
        public string AddressLine { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("remarks")]
        public string Remarks { get; set; }

        [Column("registration_number")]
        public string RegistrationNumber { get; set; }
        
        [Column("code")]
        public string Code { get; set; }

        [Column("logo_url")]
        public string LogoUrl { get; set; }
       
        [Column("rating_id")]
        public long RatingId { get; set; }

        [ForeignKey(nameof(RatingId))]
        public Rating Rating { get; set; }
    }
}
