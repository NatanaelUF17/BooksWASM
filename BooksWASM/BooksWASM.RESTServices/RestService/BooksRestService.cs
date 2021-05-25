using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Shared.Models;

namespace Server.RestService
{
    public class BooksRestService
    {
        private readonly HttpClient _client;
        readonly string BooksRestServiceUrl = "https://fakerestapi.azurewebsites.net/api/v1/Books";

        public BooksRestService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(BooksRestServiceUrl);
        }

        public async Task<List<Books>> GetBooksRestAsync()
        {
            List<Books> books = null;

            try
            {
                HttpResponseMessage response = await _client.GetAsync(_client.BaseAddress);

                if(response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    books = JsonConvert.DeserializeObject<List<Books>>(content);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return books;
        }
    }
}