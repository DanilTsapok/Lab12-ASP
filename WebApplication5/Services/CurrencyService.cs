using WebApplication5.Models;

namespace WebApplication5.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly HttpClient _httpClient;

        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ExchangeRateResponse> GetDataCurrency()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://api.privatbank.ua/p24api/exchange_rates?json&date=22.04.2023");
                var data = await response.Content.ReadFromJsonAsync<ExchangeRateResponse>();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed connection", ex);
            }
        }
    }
}