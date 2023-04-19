using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //Bütün kitapların listelerini almak için
        [HttpGet]
        public IActionResult getAllBooks()
        {
            var books = _context.Books.ToList();
            return Ok(books);
        }
        //Tek bir kitabin bilgileri almak için
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

        //Tek bir kitabin veri tabanına eklenmesi için
        [HttpPost] 
        public IActionResult CreateOneBook([FromBody] Book gelenbook)
        {
            try
            {
                if (gelenbook is null) return BadRequest(); //400

                _context.Books.Add(gelenbook);
                _context.SaveChanges();
                return StatusCode(201, gelenbook); //ekleme başarılı
                
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message); //Hata mesajını döndürüyoruz.
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult EditOneBook([FromRoute(Name = "id")] int id, [FromBody] Book gelenbook)
        {
            try
            {
                var editedbook = _context.Books.Where(b => b.Id.Equals(id)).SingleOrDefault();

                if (editedbook is null) return BadRequest();
                if (id != gelenbook.Id) return BadRequest();


                editedbook.Id = gelenbook.Id;
                editedbook.Price = gelenbook.Price;
                editedbook.Title = gelenbook.Title;
                _context.SaveChanges();
                return StatusCode(201, editedbook);



            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); //Hata mesajını döndürüyoruz.
            }
        }


        [HttpDelete("{id:int}")]
        public IActionResult DeleteAllBook([FromRoute(Name ="id")] int id)
        {
            try
            {
                var deletedvalue = _context.Books.Where(b => b.Id.Equals(id)).SingleOrDefault();
                if(deletedvalue is null) return NotFound();
                _context.Books.Remove(deletedvalue);
                _context.SaveChanges();
                return NoContent();



            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); //Hata mesajını döndürüyoruz.
            }
        }




    }
}
