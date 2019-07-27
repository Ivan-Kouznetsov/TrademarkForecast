using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using Newtonsoft.Json;
using TrademarkForecast.Models;
using TrademarkForecast.Services;
using System.Net.Http;
using System.Threading.Tasks;

namespace TrademarkForecast.DAO
{
    public static class TsdrDAO
    {
        // https://tsdrapi.uspto.gov/ts/cd/casestatus/sn86752385/info.json
        private static readonly HttpClient httpClient = new HttpClient();
        
        static TsdrDAO()
        {
            httpClient.Timeout = new TimeSpan(0, 30, 0);
        }
        
        private static async Task<string> GetApplicationAsJson(string serialNumber)
        {
            const string urlFormat = "https://tsdrapi.uspto.gov/ts/cd/casestatus/sn{0}/info.json";
            string url = String.Format(urlFormat, serialNumber);
            string response = await httpClient.GetStringAsync(url);
          
            return response;
        }

        public static string GetApplicationData(string serialNumber)
        {
            var downloadTask = GetApplicationAsJson(serialNumber);
            downloadTask.Wait();
            return downloadTask.Result;
        }

    }
}
