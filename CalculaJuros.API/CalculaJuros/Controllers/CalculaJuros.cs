using CalculaJuros.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJuros : ControllerBase
    {
        

        private readonly ILogger<CalculaJuros> _logger;
        private readonly ICalculaJurosCompostos _calculaJurosCompostos;

        public CalculaJuros(ILogger<CalculaJuros> logger, ICalculaJurosCompostos calculaJurosCompostos)
        {
            _logger = logger;
            _calculaJurosCompostos = calculaJurosCompostos;
        }

        [HttpGet(Name = "calculajuros")]
        public async Task<string> Get([FromHeader] decimal valorInicial, int tempo)
        {
            return await _calculaJurosCompostos.Calcula(valorInicial, tempo);
        }
    }
}