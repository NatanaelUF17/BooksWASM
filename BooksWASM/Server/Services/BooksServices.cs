using Server.Repository;
using Server.RestService;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWASM.Server.Services
{
    public class BooksServices : IBookRepository
    {
        BooksRestService restService;
        public BooksServices()
        {
            restService = new BooksRestService();
        }

        public async Task<List<Books>> GetAllBooksAsync()
        {
            return await restService.GetBooksRestAsync();
        }
        public async Task<Books> GetBookAsync(int id)
        {
            return await restService.GetBookRestAsync(id);
        }

        public async Task SaveBookAsync(Books book)
        {
            await restService.AddBookRestAsync(book);
        }

        public Task UpdateBookAsync(int id, Books book)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
