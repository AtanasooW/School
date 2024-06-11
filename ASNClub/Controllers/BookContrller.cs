using Microsoft.AspNetCore.Mvc;
using School.Contracts;
namespace School.Controllers
{
    public class BookContrller : BaseController
    {
        private readonly IBookService service;
        [HttpGet]
        public async Task<IActionResult> AddBook()
        {
            
            return View();
        }
    }
}
