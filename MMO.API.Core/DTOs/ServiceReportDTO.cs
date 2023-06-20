using MMO.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.DTOs
{
    public class ServiceReportDTO
    {
        public int ServiceId { get; set; }
        public string BuildingAddress { get; set; }
        public string InspectorName { get; set; }
        public decimal FinalScore { get; set; }
        public DateTime CompletedOn { get; set; }
        public IEnumerable<ServiceReport>? Reports { get; set; }
    }
}
