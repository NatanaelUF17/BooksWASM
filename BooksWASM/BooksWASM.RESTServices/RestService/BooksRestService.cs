using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BooksWASM.Shared.Models;
using Newtonsoft.Json;

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
            List<Books> books = new List<Books>();

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

        public async Task<Books> GetBookRestAsync(int id)
        {
            Books book = new Books();

            try
            {
                HttpResponseMessage response = await _client.GetAsync($"{_client.BaseAddress}/{id}");

                if(response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    book = JsonConvert.DeserializeObject<Books>(content);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return book;
        }

        public async Task AddBookRestAsync(Books book)
        {
            try
            {
                string payload = JsonConvert.SerializeObject(book);
                var content = new StringContent(payload, Encoding.UTF8, "application/json");

                await _client.PostAsync(_client.BaseAddress, content);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateBookRestAsync(int id, Books book)
        {
            try
            {
                string payload = JsonConvert.SerializeObject(book);
                var content = new StringContent(payload, Encoding.UTF8, "application/json");

                await _client.PutAsync($"{_client.BaseAddress}/{id}", content);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteBookRestAsync(int id)
        {
            var isDeleted = false;

            try
            {
                HttpResponseMessage response = await _client.DeleteAsync($"{_client.BaseAddress}/{id}");

                if(response.IsSuccessStatusCode)
                {
                    isDeleted = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return isDeleted;
        }
    }
}