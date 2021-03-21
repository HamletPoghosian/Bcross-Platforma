using Bcross.Platforma.MVC.Models.DataTransferObjects.Companies;
using Bcross.Platforma.MVC.Models.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Models.Company
{
    public class CompanyDTO
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [MaxLength(2)]
        public string CountryCode { get; set; }

        [MaxLength(3)]
        public string StateCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(10)]
        public string Zip { get; set; }

        public string Line { get; set; }
       
        [Required]
        public string Email { get; set; }
       
        [Required]
        public string Phone { get; set; }

        [MaxLength(250)]
        public string Remarks { get; set; }

        [MaxLength(50)]
        public string RegistrationNumber { get; set; }

        public string Code { get; set; }

        public string LogoUrl { get; set; }

        public RatingDTO Rating { get; set; }

    }
}
