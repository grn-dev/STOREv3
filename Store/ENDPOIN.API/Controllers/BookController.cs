using CORE.DOMAIN.Entities;
using INFRASTRUCTURES.NoSql;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOIN.API.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class BookController : ControllerBase
    {

        private readonly IMongoCollection<Book> _books;


        public BookController(IBookstoreDatabaseSettings settings)
        {

            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Book>(settings.BooksCollectionName);
        }

        [HttpGet]
        [Route("api/books")]
        public List<Book> Get()
        {
            var rest = _books.Find(book => true).ToList();
            return rest;
        }

        ////http://localhost:1234/api/student/names
        //[HttpGet]
        //[Route("api/student/names")]
        //public int Get()
        //{
        //    return 4;
        //}

        [HttpGet]
        [Route("api/books/{id:int}")]
        public Book Get(string id)
        {
            var rest = _books.Find<Book>(book => book.Id == id).FirstOrDefault();
            return rest;
        }



        [Route("api/books")]
        [HttpPost]
        public Book Create(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        //public void Update(string id, Book bookIn) =>
        //    _books.ReplaceOne(book => book.Id == id, bookIn);

        //public void Remove(Book bookIn) =>
        //    _books.DeleteOne(book => book.Id == bookIn.Id);

        //public void Remove(string id) =>
        //    _books.DeleteOne(book => book.Id == id);

    }
}
