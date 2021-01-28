using Common.Domain.Models.Response;
using Microsoft.AspNetCore.Mvc;
using PointOfSale.Application.Common.Initialize.Interfaces;
using System.Threading.Tasks;

namespace PointOfSale.Presenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InitializeController : ControllerBase
    {
        private readonly IInitializePointOfSale initialize;
        public InitializeController(IInitializePointOfSale initialize)
        {
            this.initialize = initialize;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await initialize.InitializeDatabase();

            var response = new ResponseStandardModel<string>()
            {
                Message = "Data saved successfully",
                Response = "Success"
            };
            return Ok(response);
        }
    }
}
