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

            books = await _booksServices.GetAllBooksAsync();
            
            if (books.Count > 0)
            {
                return Ok(books);
            }
           
            return NoContent();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Books>> Get(int id)
        {
            Books book;

            if (id > 0)
            {
                book = await _booksServices.GetBookAsync(id);

                if (book == null)
                {
                    return NotFound(book);
                }
            }
            else
            {
                return NotFound($"Error 404: id: {id} not found in the current context");
            }
            
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Books>> Post([FromBody] Books book)
        {

            if (book == null)
            {
                return BadRequest();
            }

            await _booksServices.SaveBookAsync(book);

            return CreatedAtAction(nameof(Get), new { id = book.Id }, book);      
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody] Books book)
        {
            if (id > 0 && book != null)
            {
                await _booksServices.UpdateBookAsync(id, book);
                return Ok();
            }

            return NotFound(id);            
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete (int id)
        {
            bool isDeleted = false;

            if (id > 0)
            {
                isDeleted = await _booksServices.DeleteBookAsync(id);
                return Ok(isDeleted);
            }

            return NoContent();
        }  
    }
}
