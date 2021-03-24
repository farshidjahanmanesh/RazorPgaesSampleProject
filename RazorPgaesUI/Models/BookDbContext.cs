using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPgaesUI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
    }
    public class BookDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public BookDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
