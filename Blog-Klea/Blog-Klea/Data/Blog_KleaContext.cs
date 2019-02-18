using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Blog_Klea.Models;

namespace Blog_Klea.Models
{
    public class Blog_KleaContext : IdentityDbContext<IdentityUser>
    {
        public Blog_KleaContext (DbContextOptions<Blog_KleaContext> options)
            : base(options)
        {
        }

        public DbSet<Blog_Klea.Models.BlogPost> BlogPost { get; set; }
        public DbSet<Blog_Klea.Models.Category> Categories { get; set; }
        public DbSet<Blog_Klea.Models.Comment> Comment { get; set; }
    }
}
