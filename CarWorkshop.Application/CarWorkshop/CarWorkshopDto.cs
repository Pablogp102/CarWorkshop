using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarWorkshop.Application.CarWorkshop
{
    public class CarWorkshopDto
    {
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name for workshop must by bettwen 2-20 letters")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Please enter a description")]
        public string? Description { get; set; }
        public string? About { get; set; }
        [StringLength(12, MinimumLength = 8)]

        public string? PhoneNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }

        public string? EncodedName { get; set; }
    }
}
