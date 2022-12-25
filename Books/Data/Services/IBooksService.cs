using Books.Data.Base;
using Books.Data.ViewModels;
using Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Data.Services
{
    public interface IBooksService:IEntityBaseRepository<Book>
    {
        Task<Book> GetBookByIdAsync(int id);
        Task<NewBookVM> GetDetailBookAsync(int id);
        Task AddNewBookAsync(NewBookVM data);
        Task UpdateBookAsync(NewBookVM data);
        Task DeleteBookAsync(int id);
    }
}
