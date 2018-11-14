﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
        : base(options)
        { }


        public DbSet<Book> Books { get; set; }
    }
    public class Book
    {
        public String ID { get; set; }
        public String Name { get; set; }
        public String ISBN { get; set; }

        public int price { get; set; }
    }
}
