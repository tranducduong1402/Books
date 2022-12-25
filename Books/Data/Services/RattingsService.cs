using Books.Data.Base;
using Books.Data.ViewModels;
using Books.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Data.Services
{
    public class RattingsService : EntityBaseRepository<Rattings>, IRattingsService
    {
        private readonly AppDbContext _context;
        public RattingsService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task AddNewRattingAsync(NewRattingVM data)
        {
            var newRatting = new Rattings()
            {
                Star = data.Star,
                Comment = data.Comment,
            };
            await _context.Rattings.AddAsync(newRatting);
            await _context.SaveChangesAsync();
        }

        public  List<GetRattingVM> GetRattingByBookIdAsync(int bookId)
        {
            var listRattings =  _context.Rattings.Where(s => s.BookId == bookId)
                .Select(s => new GetRattingVM
                {
                    //UserName = s.User.UserName,
                    RattingTime = s.RattingDate,
                    Star = s.Star,
                    Comment = s.Comment
                }).ToList();
            return  listRattings;
        }

        public bool LeaveComment(Rattings ratting)
        {
            _context.Rattings.Add(ratting);
            return _context.SaveChanges() > 0;
        }
    }
}
