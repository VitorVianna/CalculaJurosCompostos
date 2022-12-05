using Microsoft.AspNetCore.Mvc;

namespace RetornaTaxa.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaController : ControllerBase
    {
        private readonly ILogger<TaxaController> _logger;

        public TaxaController(ILogger<TaxaController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTax")]
        public decimal Get()
        {
            return 0.01M;
        }
    }
}