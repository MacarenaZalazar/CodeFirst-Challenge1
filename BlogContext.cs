using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Challenge1
{
        public class BlogContext : DbContext
        {

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-9FQDEKD\\SQLEXPRESS; Database=Blog;Trusted_Connection=True;");
            }
            //entities
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<Comment> Comments { get; set; }
        }
   
}
