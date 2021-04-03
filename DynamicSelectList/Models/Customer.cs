using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicSelectList.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [DisplayName("First Name")]
        [MaxLength(75)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(75)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Email is not valid")]
        public string EmailId { get; set; }

        [Required]
        [ForeignKey("Country")]
        [MaxLength(3)]
        [DisplayName("Country")]
        public string CountryCode { get; set; }
        public virtual Country Country { get; set; }

        [Required]
        [ForeignKey("City")]
        [MaxLength(3)]
        [DisplayName("City")]
        public string CityCode { get; set; }
        public virtual City City { get; set; }
    }
}
