using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XMLApiProject.Services.Services.Interfaces;

namespace XMLApiProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestHandlerController : ControllerBase
    {
        private IRequestHandlerService _requestHandlerService;

        public RequestHandlerController(IRequestHandlerService requestHandlerService)
        {
            _requestHandlerService = requestHandlerService;
        }

        [HttpGet]
        public async Task<ActionResult> Ping()
        {
            var response = await _requestHandlerService.Ping();
            return Ok(response);
        }
    }
}