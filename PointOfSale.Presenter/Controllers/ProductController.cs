using Common.Domain.Models.Response;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PointOfSale.Presenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryGetById<Product> getProductById;
        private readonly IRepositoryGetAll<Product> getAllProducts;

        public ProductController(
            IRepositoryGetById<Product> getProductById, 
            IRepositoryGetAll<Product> getAllProducts)
        {
            this.getProductById = getProductById;
            this.getAllProducts = getAllProducts;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await getAllProducts.Handler();
            var response = new ResponseStandardModel<IEnumerable<Product>>()
            {
                Response = products
            };
            return Ok(response);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await getProductById.Handler(id);
            
            var response = new ResponseStandardModel<Product>()
            {
                Response = product
            };
            return Ok(response);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
