using MMO.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllClients();
    }
}
