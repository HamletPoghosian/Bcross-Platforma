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
        [MaxLength(70, ErrorMessage = "The Company Name field may not be greater than 70 characters.")]
        public string Name { get; set; }

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

        [Display(Name = "AddressLines")]
        public IEnumerable<string> Lines { get; set; }

        [Display(Name = "Emails")]
        public IEnumerable<string> Emails { get; set; }

        [Display(Name = "PhoneNumbers")]
        public IEnumerable<string> Phones { get; set; }

        [MaxLength(250)]
        public string Remarks { get; set; }

        [MaxLength(50)]
        public string RegistrationNumber { get; set; }

       
    }
}
