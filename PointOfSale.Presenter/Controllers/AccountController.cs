using Common.Domain.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSale.Presenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            var response = new ResponseStandardModel<string>()
            {
                Message = "Request Failed",
                Response = returnUrl,
                Errors = new List<ErrorResponse>()
                {
                    new ErrorResponse{ 
                        AddditionalInformation = $"Could not reach the endpoint {returnUrl}",
                        ApplicationName = "Point of sale",
                        MessageError = "Authentication failed",
                        Origin = "Authentication",
                        ResponseCode = System.Net.HttpStatusCode.Unauthorized
                    }
                }
            };
            return Unauthorized(response);
        }

    }
}
