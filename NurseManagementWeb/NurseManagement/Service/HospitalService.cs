using NurseManagement.Connection;
using NurseManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NurseManagement.Service
{
    public class HospitalService
    {
        private HttpClient _client = new HttpClient();
        private async Task<string> GetAsync(string url)
        {
            return await _client.GetStringAsync(Api.Prefixo + url);
        }

        public Hospital Get(string url)
        {
            var response = _client.GetAsync(Api.Prefixo + url).GetAwaiter().GetResult();
            var result = response.Content.ReadAsAsync<Hospital>().GetAwaiter().GetResult();
            return result;
        }

        public IEnumerable<Hospital> List(string url)
        {
            var response = _client.GetAsync(Api.Prefixo + url).GetAwaiter().GetResult();
            var result = response.Content.ReadAsAsync<IEnumerable<Hospital>>().GetAwaiter().GetResult();
            return result;
        }

        public bool Post(string url, Hospital hospital)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync(Api.Prefixo + url, hospital).GetAwaiter().GetResult();
            if (!response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<bool>().GetAwaiter().GetResult();
                return result;
            }
            return response.IsSuccessStatusCode;
        }

        public bool Put(string url, Hospital hospital)
        {
            HttpResponseMessage response = _client.PutAsJsonAsync(Api.Prefixo + url, hospital).GetAwaiter().GetResult();
            if (!response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<bool>().GetAwaiter().GetResult();
                return result;
            }

            return response.IsSuccessStatusCode;
        }

        public bool Delete(string url)
        {
            HttpResponseMessage response = _client.DeleteAsync(Api.Prefixo + url).GetAwaiter().GetResult();
            if (!response.IsSuccessStatusCode == true)
            {
                var result = response.Content.ReadAsAsync<bool>().GetAwaiter().GetResult();
                return result;
            }
            return response.IsSuccessStatusCode;
        }
    }
}
