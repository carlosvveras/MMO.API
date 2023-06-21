//using MMO.API.Core.Entities;
//using MMO.API.Core.Interfaces;
//using MMO.API.Core.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MMO.API.Core.Services
//{
//    public class ClientService : IClientService
//    {
//        private readonly IClientRepository _clientRepository;
//        public ClientService(IClientRepository clientRepository)
//        {
//            _clientRepository = clientRepository;
//        }

//        public async Task<IEnumerable<Client>> GetAllClients()
//        {
//            var clients = await _clientRepository.GetAllClients();
//            return clients;
//        }

//    }
//}


using Microsoft.Extensions.Logging;
using MMO.API.Core.Entities;
using MMO.API.Core.Interfaces;
using MMO.API.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMO.API.Core.Services
{
    public class ClientService : IClientService
    {
        private readonly ILogger<ClientService> logger;
        private readonly IRepository<Client> repository;

        public ClientService(IRepository<Client> _repository, ILogger<ClientService> _logger)
        {
            this.repository = _repository;
            this.logger = _logger;
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Client> Getclient(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<bool> Findclient(int id)
        {
            var client = await repository.GetById(id);
            return (client != null ? true : false);
        }

        public async Task<Client> AddClientAsync(Client client)
        {
            await repository.AddAsync(client);
            return client;
        }

        public async Task<bool> UpdateclientAsync(int clientId, Client client)
        {
            return await repository.UpdateAsync(clientId, client);
        }

        public async Task DeleteclientAsync(int clientId)
        {
            await repository.DeleteAsync(clientId);
        }


    }
}

