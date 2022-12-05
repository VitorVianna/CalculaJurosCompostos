using RestSharp;

namespace CalculaJuros.API.Repository.External
{
    public class BuscaTaxaJuros : IBuscaTaxaJuros
    {
        private readonly IConfiguration _configuration;

        public BuscaTaxaJuros(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<decimal> RetonarTaxaJuros()
        {
            string url = _configuration.GetSection("EndpointTaxaJuros").Value;
            var client = new RestClient(url);
            var request = new RestRequest("Taxa",Method.Get);
            var response = await client.GetAsync<decimal>(request);
            return response;
        }

    }
}
