using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class BlogContent:DbContext

    { 
        public BlogContent(DbContextOptions<BlogContent> options) : base(options)
        {
            
        }

        public DbSet<Author> Authors { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Blog> Blogs { set; get; }


    }
}
