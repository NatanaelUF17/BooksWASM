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
        public async Task<ActionResult<IEnumerable<Books>>> Get()
        {
            List<Books> books;

            try
            {
                books = await _booksServices.GetAllBooksAsync();
                if (books.Count > 0)
                {
                    return Ok(books);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return NoContent();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Books>> Get(int id)
        {
            Books book;

            try
            {
                if(id > 0)
                {
                    book = await _booksServices.GetBookAsync(id);

                    if(book == null)
                    {
                        return NotFound(book);
                    }
                }
                else
                {
                    return NotFound(id);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Books>> Post([FromBody] Books book)
        {
            try
            {
                if(book == null)
                {
                    return BadRequest();
                }

                await _booksServices.SaveBookAsync(book);

                return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody] Books book)
        {
            try
            {
                if(id > 0 && book != null)
                {
                    await _booksServices.UpdateBookAsync(id, book);
                    return Ok();
                }

                return NotFound(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
