using MMO.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.API.Core.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllClients();
    }
}
