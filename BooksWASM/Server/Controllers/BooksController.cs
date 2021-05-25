using BooksWASM.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _booksServices;

        public BooksController(IBookRepository booksServices)
        {
            _booksServices = booksServices;
        }

        [HttpGet]
        public async Task<IEnumerable<Books>> Get()
        {
            return await _booksServices.GetAllBooksAsync();
        }
    }
}
