using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.Entities
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Company Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Company Name must have at least 1 and 100 maximum characters.")]
        [DataType(DataType.Text)]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Contact Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Contact Name must have at least 1 and 100 maximum characters.")]
        [DataType(DataType.Text)]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Address must have at least 1 and 100 maximum characters.")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Postal Code is required.")]
        [StringLength(10, ErrorMessage = "Postal Code must have 10 maximum characters.")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(30, ErrorMessage = "City must have 30 maximum characters.")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required(ErrorMessage = "State/Province is required.")]
        [StringLength(30, ErrorMessage = "State/Province must have 30 maximum characters.")]
        [DataType(DataType.Text)]
        public string StateProvince { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [StringLength(30, ErrorMessage = "Country must have 30 maximum characters.")]
        [DataType(DataType.Text)]
        public string Country { get; set; }

        [Required(ErrorMessage = "E-mail is required.")]
        [StringLength(100, ErrorMessage = "E-mail must have 100 maximum characters.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        [StringLength(20, ErrorMessage = "Phone must have 20 maximum characters.")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [StringLength(500, ErrorMessage = "Description must have 500 maximum characters.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [NotMapped]
        public virtual IEnumerable<Building> Buildings { get;}
    }
}
