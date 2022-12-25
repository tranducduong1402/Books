using Books.Data;
using Books.Data.Services;
using Books.Data.ViewModels;
using Books.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace Books.Controllers
{
    public class RattingsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IRattingsService _service;

        public RattingsController(AppDbContext context, IRattingsService service)
        {
            _context = context;
            _service = service;
        }

        [HttpPost]
        public ActionResult Add(NewBookVM vm)
        {
            //var checkReview = _context.Rattings.Where(s => s.UserId.Contains(this.User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault();
            //if(checkReview != null)
            //{
            //    return BadRequest();
            //    throw new Exception("Bạn đã đánh giá sản phẩm này!");
            //}
            var comment = vm.Comment;
            var bookId = vm.Id;
            var star = vm.Star;

            Rattings ratting = new Rattings()
            {
                BookId = bookId,
                Star = star,
                Comment = comment,
                RattingDate = DateTime.Now,
                UserId = _context.Users.Where(s => s.Id == this.User.FindFirstValue(ClaimTypes.NameIdentifier)).Select(s => s.UserName).FirstOrDefault()
            };
            _context.Rattings.Add(ratting);
            _context.SaveChanges();
            return RedirectToAction("Details", "Books", new { id = bookId });
        }

        public async Task<IActionResult> Create()
        {

            return View("Details", "Books");
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewRattingVM ratting)
        {
            if (!ModelState.IsValid)
            {
                return View(ratting);
            }

            await _service.AddNewRattingAsync(ratting);
            return RedirectToAction("Details", "Books");
        }

        [HttpPost]
        public IActionResult LeaveComment(NewRattingVM model)
        {

            var ratting = new Rattings();
            ratting.Comment = model.Comment;
            //ratting.Id = model.Id;
            ratting.RecordId = model.RecordId;
            ratting.UserId = User.Identity.Name;
            ratting.RattingDate = System.DateTime.Now;

            _service.LeaveComment(ratting);

            return View();
        }
    }
}
