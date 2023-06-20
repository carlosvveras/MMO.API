using MMO.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.DTOs
{
    public class BuildingDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ClientId { get; set; }
        //public IEnumerable<Amenity> Amenities { get; set; }
    }
}
