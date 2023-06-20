using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int BuildingId { get; set; }
        public int InspectorId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }
        public virtual IEnumerable<ServiceReport> Reports { get; set; }

    }
}