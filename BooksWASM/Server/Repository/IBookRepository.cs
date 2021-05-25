using System.Threading.Tasks;
using System.Collections.Generic;

namespace Server.Repository
{
    public interface IBookRepository<Books>
    {
        Task<List<Books>> GetAllBooksAsync(); 
        Task<Books> GetBookAsync(int id);
        Task SaveBookAsync(Books book);
        Task UpdateBookAsync(int id, Books book);
        Task DeleteBookAsync(int id);
    }
}