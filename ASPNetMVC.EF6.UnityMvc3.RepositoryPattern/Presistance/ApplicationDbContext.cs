using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Presistance
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnectionString")
        {

        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}