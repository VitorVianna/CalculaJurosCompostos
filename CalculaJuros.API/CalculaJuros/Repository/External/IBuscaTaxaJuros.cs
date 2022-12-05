namespace CalculaJuros.API.Repository.External
{
    public interface IBuscaTaxaJuros
    {
        public Task<decimal> RetonarTaxaJuros();
    }
}
