using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMSAPP.Shared;

namespace WMSAPP.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactController : ControllerBase
    {
        private readonly ILogger<TransactController> _logger;
        public TransactController(ILogger<TransactController> logger)
        {
            _logger = logger;
        }


    }
}
