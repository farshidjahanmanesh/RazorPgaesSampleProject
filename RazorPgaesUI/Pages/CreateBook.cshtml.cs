using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPgaesUI.Models;

namespace RazorPgaesUI.Pages
{
    public class CreateBookModel : PageModel
    {
        private readonly BookDbContext bookDbContext;

        public CreateBookModel(BookDbContext bookDbContext)
        {
            this.bookDbContext = bookDbContext;
        }
        [BindProperty]
        public Book Book { get; set; }
        public void OnGetCreate()
        {

        }
        public void OnGet()
        {
            this.OnGetCreate();
        }
        public IActionResult OnPostCreate()
        {
            if (!ModelState.IsValid)
                return Page();

            Book.CreateAt = DateTime.Now;
            bookDbContext.Add(Book);
            bookDbContext.SaveChanges();
            return RedirectToPage("/index");
        }
    }
}
