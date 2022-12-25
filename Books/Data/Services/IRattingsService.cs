using Books.Data.Base;
using Books.Data.ViewModels;
using Books.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.Data.Services
{
    public interface IRattingsService : IEntityBaseRepository<Rattings>
    {
        List<GetRattingVM> GetRattingByBookIdAsync(int bookId);
        Task AddNewRattingAsync(NewRattingVM data);
        bool LeaveComment(Rattings ratting);
    }
}
