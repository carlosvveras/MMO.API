using MMO.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.DTOs
{
    public class ClientDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<BuildingDTO> Buildings { get; }
    }
}
