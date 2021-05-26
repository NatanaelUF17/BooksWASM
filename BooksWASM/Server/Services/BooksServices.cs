using BooksWASM.Shared.Models;
using Server.Repository;
using Server.RestService;
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
            Books book = new Books();

            try
            {
                book = await restService.GetBookRestAsync(id);

                if (book != null)
                {
                    return book;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return book;
        }

        public async Task SaveBookAsync(Books book)
        {
            try
            {
                if(book != null)
                {
                    await restService.AddBookRestAsync(book);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateBookAsync(int id, Books book)
        {
            var oldBook = await restService.GetBookRestAsync(id);
            
            try
            {
                if(oldBook != null)
                {
                    await restService.UpdateBookRestAsync(id, oldBook);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            bool isDeleted = false;

            try
            {
                if (id > 0)
                {
                    isDeleted = await restService.DeleteBookRestAsync(id);
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
