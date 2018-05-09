using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("EntityFrameworkPractice") { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Class> Classes {get; set;}
    }
}