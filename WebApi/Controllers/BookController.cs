using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly RepositoryContext _context;

        public BookController (RepositoryContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult getAllBooks()
        {
            var books = _context.Books.ToList();
            return Ok(books);
        }

        [HttpGet("{id:int}")]
        public IActionResult getBookByID([FromRoute(Name ="id")] int id)
        {
            var book = _context.Books.Where(b => b.Id.Equals(id)).SingleOrDefault();
            if(book == null)
            {
                return NotFound();
            }
            else
                return Ok(book);    
        }


        [HttpPost] 
        public IActionResult CreateOneBook([FromBody] Book gelenbook)
        {
            try
            {
                if (gelenbook is null) return BadRequest();

                _context.Books.Add(gelenbook);
                _context.SaveChanges();
                return StatusCode(201, gelenbook);
                
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
