using BookStoreHammondMission11Take2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BookStoreHammondMission11Take2.Models.ViewModels;

namespace BookStoreHammondMission11Take2.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new BookListViewModel
            {
                Books = _repo.Books
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }

            };

            return View(blah);
        }

        

        
    }
}
