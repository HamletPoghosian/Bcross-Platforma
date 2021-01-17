using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bcross.Platforma.Application.DataTransferObjects
{
   public class CompanyDto
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(70, ErrorMessage = "The Company Name field may not be greater than 70 characters.")]
        public string Name { get; set; }

        [Required]
        public AddressDto Address { get; set; }


        [MaxLength(50)]
        public string RegistrationNumber { get; set; }


        [MaxLength(50)]
        public string VAT { get; set; }
    }
}
