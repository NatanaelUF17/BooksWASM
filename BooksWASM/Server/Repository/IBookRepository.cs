using System.Threading.Tasks;
using System.Collections.Generic;
using BooksWASM.Shared.Models;

namespace Server.Repository
{
    public interface IBookRepository
    {
        Task<List<Books>> GetAllBooksAsync(); 
        Task<Books> GetBookAsync(int id);
        Task SaveBookAsync(Books book);
        Task UpdateBookAsync(int id, Books book);
        Task<bool> DeleteBookAsync(int id);
    }
}