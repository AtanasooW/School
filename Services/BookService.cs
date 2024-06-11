using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Data.Models;
using School.ViewModels;
using Contracts;
namespace Services
{
    public class BookService : IBookService
    {
        private readonly SchoolContext db;

        public BookService(SchoolContext context)
        {
            db = context;
        }
        public async Task<AddBookViewModel> GetAddBookViewModelAsync()
        {
            return new AddBookViewModel();
        }
        public async Task AddBook(AddBookViewModel model)
        {
            var book = new Book
            {
                Id = model.Id,
                Author = model.Author,
                Title = model.Title,
                Category = model.Category,
            };
            await db.AddAsync(book);
            await db.SaveChangesAsync();
        }
        public async Task<BookDetailsViewModel?> GetBookByIdAsync(Guid Id)
        {
            var book = await db.Books.Where(x => x.Id == Id).Select(x => new BookDetailsViewModel
            {
                Id = x.Id,
                Author = x.Author,
                Title = x.Title,
                Category = x.Category,
            }).FirstOrDefaultAsync();
            return book;

        }
    }
}
