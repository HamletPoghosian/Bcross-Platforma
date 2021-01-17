using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bcross.Platforma.Application.DataTransferObjects
{
    public class AddressDto
    {
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
    }
}
