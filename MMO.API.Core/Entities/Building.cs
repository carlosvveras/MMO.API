using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.Entities
{
    [Table("Building")]
    public class Building
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Client.Id))]
        [Required(ErrorMessage = "Client Id is required.")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Building Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Building Name must have at least 1 and 100 maximum characters.")]
        [DataType(DataType.Text)]
        public string BuildingName { get; set; }

        [Required(ErrorMessage = "Company Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Company Name must have at least 1 and 100 maximum characters.")]
        [DataType(DataType.Text)]
        public string Address { get; set; }
        
        public virtual ICollection<Amenity> Amenities { get; set;}

        public Building()
        {
            this.Amenities = new HashSet<Amenity>();
        }
    }
}
