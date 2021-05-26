using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksWASM.Shared.Models;

namespace BooksWASM.Client.Services
{
    public interface IBooksServices
    {
        Task<Books[]> GetBooks();
        Task<Books> GetBook(int id);

    }
}
