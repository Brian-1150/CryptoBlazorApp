using Crypto.Data.Interfaces;
using Crypto.Data.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;


namespace Crypto.Service
{

    public class CryptoApiService : ICryptoApiService
    {
        private readonly IOptions<WebApiOptions> _options;
        public CryptoApiService(IOptions<WebApiOptions> options)
        {
            _options = options;
        }

        private static readonly HttpClient client;
        static CryptoApiService()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://min-api.cryptocompare.com"), 
                                           
            };
                    }
        public async Task<CryptoCoinModel> GetCryptoCoins(string symbol, double amountOwned)
        {
            string key = _options.Value.ApiKey; 

            var url = string.Format($"/data/price?fsym={symbol}&tsyms=USD,BTC,EUR&api_key={key}");
            var result = new CryptoCoinModel();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                if (stringResponse.Contains("Error"))
                    return new CryptoCoinModel { AmountOwned = 0 };
                result = JsonSerializer.Deserialize<CryptoCoinModel>(stringResponse);
                result.Symbol = symbol;
                result.AmountOwned = amountOwned;
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
            return result;

        }
    }
}
