using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using pos.context.dbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pos.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly PosDbContext _contex;

        public ProductController(ILogger<ProductController> logger, PosDbContext contex)
        {
            _logger = logger;
            _contex = contex;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _contex.Product.ToListAsync();
            return Ok(users);
        }
    }
}
