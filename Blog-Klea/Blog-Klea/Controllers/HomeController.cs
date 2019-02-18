using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog_Klea.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog_Klea.Controllers
{
    public class HomeController : Controller
    {
        private readonly Blog_KleaContext _context;

        public HomeController(Blog_KleaContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> Index(string searchString)
        {
            var posts = from p in _context.BlogPost select p;

            if(!String.IsNullOrEmpty(searchString))
            {
                posts = posts.Where(p1 => p1.Title.Contains(searchString));
            }
            return View(await posts.ToListAsync());
        }

 

        public async Task<IActionResult> Filter(string filter)
        {

            var posts = from p in _context.BlogPost select p;

            if (!String.IsNullOrEmpty(filter))
            {
                posts = posts.Where(p1 => p1.cats.Contains(filter));
            }
            ViewData["posts"] = posts;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
