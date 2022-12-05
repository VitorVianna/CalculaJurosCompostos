namespace CalculaJuros.API.Repository
{
    public interface ICalculaJurosCompostos
    {
        public Task<string> Calcula(decimal valorInicial, int tempo);
    }
}
