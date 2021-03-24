using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPgaesUI.Models;
using RazorPgaesUI.Models.ViewModels;

namespace RazorPgaesUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BookDbContext bookDbContext;

        public IndexModel(BookDbContext bookDbContext)
        {
            this.bookDbContext = bookDbContext;
        }
        public List<Book> Books { get; set; }
        public void OnGet()
        {
            Books = bookDbContext.Books.ToList();
        }

        public JsonResult OnPostDelete([FromBody] DeleteBookViewModel data)
        {
            bookDbContext.Books.Remove(new Book() { Id = data.Id });
            bookDbContext.SaveChanges();
            return new JsonResult("success");
        }
    }

   
}
