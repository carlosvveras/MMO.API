using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MMO.API.Core.DTOs;
using MMO.API.Core.Interfaces;

namespace MMO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService clientService;
        private readonly ILogger<ClientController> logger;
        public ClientController(IClientService _clientService, ILogger<ClientController> _logger)
        {
            this.clientService = _clientService;
            this.logger = _logger;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDTO>>> GetProduct()
        {
            return Ok(await clientService.GetAllClients());
        }


        //[HttpGet("{id}")]

        //public async Task<IActionResult> GetProduct(int id)
        //{
        //    if (!ProductExists(id))
        //    {
        //        return NotFound();
        //    }
        //    return Ok(await clientService.GetProduct(id));
        //}


        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProduct(int id, Product product)
        //{
        //    if (id != product.Product_Id)
        //        return BadRequest();

        //    if (!ProductExists(id))
        //        return NotFound();

        //    product.ModificationDate = DateTime.Now;

        //    await clientService.UpdateProductAsync(id, product);

        //    return Ok();
        //}


        //[HttpPost]
        //public async Task<IActionResult> PostProduct(Product product)
        //{
        //    if (ProductExists(product.Product_Id))
        //    {
        //        return BadRequest(product);
        //    }

        //    product.CreationDate = DateTime.Now;
        //    product.ModificationDate = DateTime.Now;

        //    return Ok(await clientService.AddProductAsync(product));
        //}


        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduct(int id)
        //{
        //    if (!ProductExists(id))
        //    {
        //        return NotFound();
        //    }

        //    await clientService.DeleteProductAsync(id);
        //    return Ok();
        //}

        //private bool ProductExists(int id)
        //{
        //    return clientService.FindProduct(id).Result;
        //}
    }
}
