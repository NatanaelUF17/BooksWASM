using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BooksWASM.Shared.Models;

namespace BooksWASM.Client.Services
{
    public class BooksServices : IBooksServices
    {
        private readonly HttpClient Http;
        private readonly string Url = "api/Books";

        public BooksServices(HttpClient client)
        {
            Http = client;
        }

        public async Task<Books> GetBook(int id)
        {
            return await Http.GetFromJsonAsync<Books>($"{Url}/{id}");
        }

        public async Task<Books[]> GetBooks()
        {
            return await Http.GetFromJsonAsync<Books[]>(Url);
        }
    }
}
