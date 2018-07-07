using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Models;
using System.Data.Entity;

namespace ShoppingCart.DAL
{
    public class BookInitializer:DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var author = new Author
            {
                Biography = "...",
                FirstName = "Jamie",
                LastName = "Munro"
            };

            var books = new List<Book>
            {
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "11111111",
                    Synopsis = "...",
                    Title = "aaaaa"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "22222222",
                    Synopsis = "...",
                    Title = "bbbbb"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "333333333",
                    Synopsis = "...",
                    Title = "cccccccc"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "4444444444",
                    Synopsis = "...",
                    Title = "dddddddd"
                }
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
                
            }
        }
   }