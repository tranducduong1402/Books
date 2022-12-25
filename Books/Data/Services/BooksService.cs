using Books.Data.Base;
using Books.Data.ViewModels;
using Books.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Data.Services
{
    public class BooksService : EntityBaseRepository<Book>, IBooksService
    {
        private readonly AppDbContext _context;
        //private readonly IRattingsService _rattingsService;
        public BooksService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewBookAsync(NewBookVM data)
        {
            var newBook = new Book()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                Count = data.Count,
                ReleaseDate = data.ReleaseDate,
                PageNumber = data.PageNumber,
                BookType = data.BookType,
                Author = data.Author
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await  _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            var bookDetails = await _context.Books.Where(s => s.Id == id)
                .FirstOrDefaultAsync();

            return bookDetails;
        }

        public async Task<NewBookVM> GetDetailBookAsync(int id)
        {
            return await _context.Books.Where(s => s.Id == id)
                .Select(s => new NewBookVM
                {
                    Name = s.Name,
                    Author = s.Author,
                    Description = s.Description,
                    Price = s.Price,
                    Count = s.Count,
                    PageNumber = s.PageNumber,
                    ImageURL = s.ImageURL,
                    ReleaseDate = s.ReleaseDate,
                    BookType = s.BookType,
                }).FirstOrDefaultAsync();
        }

        public async Task UpdateBookAsync(NewBookVM data)
        {
            var dbBook = await _context.Books.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbBook != null)
            {
                dbBook.Name = data.Name;
                dbBook.Description = data.Description;
                dbBook.Price = data.Price;
                dbBook.ImageURL = data.ImageURL;
                dbBook.Count = data.Count;
                dbBook.ReleaseDate = data.ReleaseDate;
                dbBook.PageNumber = data.PageNumber;
                dbBook.BookType = data.BookType;
                dbBook.Author = data.Author;
                await _context.SaveChangesAsync();
            }
        }
    }
}
