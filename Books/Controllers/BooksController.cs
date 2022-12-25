using Books.Data;
using Books.Data.Services;
using Books.Data.Static;
using Books.Data.ViewModels;
using Books.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IBooksService _service;

        public BooksController(AppDbContext context, IBooksService service)
        {
            _context = context;
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allBooks = await _service.GetAllAsync();
            return View(allBooks);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allBooks = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allBooks.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allBooks.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allBooks);
        }

        //GET: Movies/Details/1
        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
           if(id == null)
            {
                return BadRequest();
            }

            Book book = _context.Books.Find(id);
            NewBookVM vm = new NewBookVM();

            if(book == null)
            {
                return NotFound();
            }

            vm.Id = book.Id;
            vm.Name = book.Name;
            vm.Author = book.Author;
            vm.Description = book.Description;
            vm.BookType = book.BookType;
            vm.PageNumber = book.PageNumber;
            vm.ReleaseDate = book.ReleaseDate;
            vm.Price = book.Price;
            vm.Count = book.Count;
            vm.ImageURL = book.ImageURL;

            var comments = _context.Rattings.Where(s => s.BookId.Equals(id.Value)).ToList();
            vm.ListOfComments = comments;

            var stars = _context.Rattings.Where(s => s.Id.Equals(id.Value)).ToList();
            if(stars.Count > 0)
            {
                var starSum = stars.Sum(s => s.Star);
                ViewBag.RattingSum = starSum;
                var starCount = stars.Count();
                ViewBag.RattingCount = starCount;

            }
            else
            {
                ViewBag.RattingSum = 0;
                ViewBag.RattingCount = 0;
            }
            return View(vm);
        }

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewBookVM book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            await _service.AddNewBookAsync(book);
            return RedirectToAction(nameof(Index));
        }


        //GET: books/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var bookDetails = await _service.GetBookByIdAsync(id);
            if (bookDetails == null) return View("NotFound");

            var response = new NewBookVM()
            {
                Id = bookDetails.Id,
                Name = bookDetails.Name,
                Description = bookDetails.Description,
                Price = bookDetails.Price,
                ReleaseDate = bookDetails.ReleaseDate,
                Count = bookDetails.Count,
                ImageURL = bookDetails.ImageURL,
                BookType = bookDetails.BookType,
                PageNumber = bookDetails.PageNumber,
                Author = bookDetails.Author,
            };

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewBookVM book)
        {
            if (id != book.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                return View(book);
            }

            await _service.UpdateBookAsync(book);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var bookDetails = await _service.GetBookByIdAsync(id);
            if (bookDetails == null) return View("NotFound");

            var response = new NewBookVM()
            {
                Id = bookDetails.Id,
                Name = bookDetails.Name,
                Description = bookDetails.Description,
                Price = bookDetails.Price,
                ReleaseDate = bookDetails.ReleaseDate,
                Count = bookDetails.Count,
                ImageURL = bookDetails.ImageURL,
                BookType = bookDetails.BookType,
                PageNumber = bookDetails.PageNumber,
                Author = bookDetails.Author,
            };

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, NewBookVM book)
        {
            if (id != book.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                return View(book);
            }

            await _service.DeleteBookAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}