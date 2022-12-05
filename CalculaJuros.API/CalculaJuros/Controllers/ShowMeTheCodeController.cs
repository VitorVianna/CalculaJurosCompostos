using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet(Name = "showmethecode")]
        public string Get()
        {
            return "https://github.com/VitorVianna/CalculaJurosCompostos";
        }
    }
}
