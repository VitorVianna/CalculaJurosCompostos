using CalculaJuros.API.Repository.External;

namespace CalculaJuros.API.Repository
{
    public class CalculaJurosCompostos : ICalculaJurosCompostos
    {
        public IBuscaTaxaJuros _buscaTaxaJuros;

        public CalculaJurosCompostos(IBuscaTaxaJuros buscaTaxaJuros)
        {
            _buscaTaxaJuros = buscaTaxaJuros;
        }
        public async Task<string> Calcula(decimal valorInicial, int tempo)
        {
            var taxaJuros = await _buscaTaxaJuros.RetonarTaxaJuros();
            var retorno = Math.Round(valorInicial * Convert.ToDecimal((Math.Pow((1 + (double)taxaJuros), tempo))),2);
            return retorno.ToString("#.##");
        }
    }
}
