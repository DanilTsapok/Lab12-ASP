using WebApplication5.Models;

namespace WebApplication5.Services
{
    public interface ICurrencyService
    {
        Task<ExchangeRateResponse> GetDataCurrency();
    }
}