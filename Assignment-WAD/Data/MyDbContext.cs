using Assignment_WAD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment_WAD.Data
{
    public class MyDbContext
    {
        public class MyDBContext : DbContext
        {
            public MyDBContext() : base("name=MyDBContext")
            {

            }
            public DbSet<Student> Students { get; set; }
        }
    }
}