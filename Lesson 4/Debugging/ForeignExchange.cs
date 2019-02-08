using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Newtonsoft.Json;

//foreign exchange rates using exchangeratesapi.io

namespace ForeignExchange
{
    public class ExchangeRates
    {
        private static readonly HttpClient client = new HttpClient();

        [JsonProperty("base")]
        public string baseCurrency { get; set; }
        public DateTime date { get;set;}
        public Dictionary<string, decimal> rates {get;set;}

        public static async Task<ExchangeRates> GetRatesForBaseAsync(string baseCurrency)
        {
            client.BaseAddress = new Uri("https://api.exchangeratesapi.io/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ExchangeRates rates = await GetExchangeRatesAsync($"latest?base={baseCurrency}");
            return rates;
            
        }

        public static async Task<History> GetExchangeRateHistory(DateTime startDate, DateTime endDate, string baseCurrency = "USD")
        {
            client.BaseAddress = new Uri("https://api.exchangeratesapi.io/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            History rates = null;
            string path = $"history?start_at={startDate.ToString("yyyy-MM-dd")}&end_at={endDate.ToString("yyyy-MM-dd")}&base={baseCurrency}";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                rates=  await response.Content.ReadAsAsync<History>();
            }
            return rates;
        }

        public static async Task<ExchangeRates> GetExchangeRatesAsync(string path)
        {
            ExchangeRates rates = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                rates = await response.Content.ReadAsAsync<ExchangeRates>();
            }
            return rates;
        }

        public class History
        {
            [JsonProperty("base")]
            public string baseCurrency { get; set; }
            public DateTime end_at { get; set; }
            public DateTime start_at { get; set; }
            public Dictionary<DateTime, Dictionary<string, decimal>> rates { get; set; }
        }

    }
}