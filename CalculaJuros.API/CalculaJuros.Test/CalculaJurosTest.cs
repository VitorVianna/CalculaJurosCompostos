using CalculaJuros.API.Repository;
using Xunit;

namespace CalculaJuros.Test
{
    public class CalculaJurosTest
    {
        private readonly ICalculaJurosCompostos _calculaJurosCompostos;
        public CalculaJurosTest(ICalculaJurosCompostos calculaJurosCompostos)
        {
            _calculaJurosCompostos = calculaJurosCompostos;
        }

        [Fact]
        public void ValorInicial100_Tempo5_DeveRetornar10510()
        {
            var ValorInicial = 100M;
            var tempo = 5;

            var calculaJuros = _calculaJurosCompostos.Calcula(ValorInicial, tempo);

            // Assert
            Assert.Equals(calculaJuros, "105,1");
        }
    }
}