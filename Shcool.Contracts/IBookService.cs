using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.ViewModels;

namespace School.Contracts
{
    public interface IBookService
    {
        Task<AddBookViewModel> GetAddBookViewModelAsync();
        Task AddBook(AddBookViewModel model);
        Task<BookDetailsViewModel?> GetBookByIdAsync(Guid Id);
    }
}
