using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blog_Klea.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using Blog_Klea.Data.FileManager;
using System.Collections;

namespace Blog_Klea.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly Blog_KleaContext _context;
        private IFileManager _fileManager;

        public BlogPostController(Blog_KleaContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: BlogPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogPost.ToListAsync());
        }
        // GET: BlogPosts/Details/5
        public async Task<IActionResult> Details(int id)
        {
            IList<Comment> allcomments = new List<Comment>();
            foreach (Comment c in _context.Comment)
            {
                if (c.BlogPostId==id)
                {
                    allcomments.Add(c);
                }
               
            }
            ViewData["Comments"] = allcomments;
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPost
                .FirstOrDefaultAsync(m => m.ID == id);
            if (blogPost == null)
            {
                return NotFound();
            }
            return View(blogPost);
        }


        [Authorize]
        public IActionResult AddComment()
        {
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment([Bind("ID,Content,PublicationDate,BlogPostID")] Comment comment )
        {
            if (ModelState.IsValid)
            {
                comment.PublicationDate = DateTime.Now;
                comment.BlogPostId = 1;

                _context.Add(comment);
                await _context.SaveChangesAsync();
        
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return Content(string.Join(" | ", ModelState.Values
                                           .SelectMany(v => v.Errors)
                                           .Select(e => e.ErrorMessage)));
            }
            return View(comment);
        }


        [Authorize]
        // GET: BlogPosts/Create
        public IActionResult Create()
        {
            List<string> l1 = new List<string>();
            var categories = _context.Categories;
            foreach(Category c in categories)
            {
                l1.Add(c.catname);
            }

            List<Category> L2 = new List<Category>();
            var cat = _context.Categories;
            foreach(Category c in cat)
            {
                L2.Add(c);
            }
            ViewData["categories"] =l1 ;
            ViewData["cat"]=L2;
            return View();
        }

        // POST: BlogPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598. ImageURL,Slug,IsPublished,
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Content,Image,PubDate,Category,cats")] BlogPost blogPost, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                blogPost.PubDate = DateTime.Now;

                if (Image != null)
                {

                    blogPost.Image = await _fileManager.SaveImage(Image);                    
                }
                string ctg = "";
                bool yes = false;
                foreach (string a in blogPost.cats.Split(" "))
                {
                    foreach (Category i in _context.Categories)
                    {
                        if (i.catname == a)
                        {
                            yes = true;
                        }

                    }
                    if (yes == true)
                    {
                        ctg += a;
                        ctg += " ";
                        yes = false;
                    }
                }

                blogPost.cats = ctg;
               
                _context.Add(blogPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return Content(string.Join(" | ", ModelState.Values
                                            .SelectMany(v => v.Errors)
                                            .Select(e => e.ErrorMessage))); 
            }
            return View(blogPost);
        }

        [Authorize]
        // GET: BlogPosts/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            List<string> l1 = new List<string>();
            var categories = _context.Categories;
            foreach (Category c in categories)
            {
                l1.Add(c.catname);
            }

            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPost.FindAsync(id);
            if (blogPost == null)
            {
                return NotFound();
            }
            ViewData["Categories"] = l1;
            return View(blogPost);
        }

        // POST: BlogPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,PubDate,Image,Content,cats")] BlogPost blogPost, IFormFile Image)
        {
            if (id != blogPost.ID)
            {
                return NotFound();
            }

            if (Image != null)
            {

                blogPost.Image = await _fileManager.SaveImage(Image);
            }


            string ctg = "";
            bool yes = false;
            foreach (string a in blogPost.cats.Split(" "))
            {
                foreach (Category i in _context.Categories)
                {
                    if (i.catname == a)
                    {
                        yes = true;
                    }

                }
                if (yes == true)
                {
                    ctg += a;
                    ctg += " ";
                    yes = false;
                }
            }

            blogPost.cats = ctg;

            if (ModelState.IsValid)
            {
              

                try
                {
                    _context.Update(blogPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogPostExists(blogPost.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blogPost);
        }

        [Authorize]
        // GET: BlogPosts/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPost
                .FirstOrDefaultAsync(m => m.ID == id);
            if (blogPost == null)
            {
                return NotFound();
            }
            return View(blogPost);
        }

        // POST: BlogPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogPost = await _context.BlogPost.FindAsync(id);
            _context.BlogPost.Remove(blogPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostExists(int id)
        {
            return _context.BlogPost.Any(e => e.ID == id);
        }
    }
}
