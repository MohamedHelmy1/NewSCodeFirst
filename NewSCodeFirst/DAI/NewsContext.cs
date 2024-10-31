using Microsoft.EntityFrameworkCore;
using NewSCodeFirst.DAI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSCodeFirst.DAI
{
    public class NewsContext:DbContext
    {
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Cataloge> Cataloges { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.; Database=News;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
