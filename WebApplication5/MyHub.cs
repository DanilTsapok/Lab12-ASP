using Microsoft.AspNetCore.SignalR;
using WebApplication5.Services;

namespace WebApplication5
{
    public class MyHub :Hub
    {
        private readonly ICurrencyService _currencyService;

        public MyHub(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }
        public async Task GetDataCurrency()
        {
            var data=await _currencyService.GetDataCurrency();
            await Clients.All.SendAsync("ReceiveData", data);
        }
    }
}
