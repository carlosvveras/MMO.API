using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.Entities
{
    public class ServiceReport
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BuildingId { get; set; }
        public DateTime CompletedDateTime { get; set; }
        public Amenity Amenity { get; set; }
        public decimal Score { get; set; }
        public string Comments { get; set; }

    }
}
