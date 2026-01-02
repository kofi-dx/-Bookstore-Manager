using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bookstore.Data;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookstoreContext _context;

        public HomeController(ILogger<HomeController> logger, BookstoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var recentBooks = await _context.Books
                .Take(3) // Just take 3 books, no ordering by CreatedDate
                .ToListAsync();
            
            ViewData["RecentBooks"] = recentBooks;
            ViewData["TotalBooks"] = await _context.Books.CountAsync();
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}