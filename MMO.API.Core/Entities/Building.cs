using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.Entities
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ClientId { get; set; }
        public virtual ICollection<Amenity> Amenities { get; set;}

        public Building()
        {
            this.Amenities = new HashSet<Amenity>();
        }
    }
}
