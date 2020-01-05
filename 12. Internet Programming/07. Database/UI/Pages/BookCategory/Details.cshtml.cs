using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Entity;

namespace UI.BookCategoryPages
{
    public class DetailsModel : PageModel
    {
        private readonly CodeFirst.Entity.CodeFirstContext _context;

        public DetailsModel(CodeFirst.Entity.CodeFirstContext context)
        {
            _context = context;
        }

        public BookCategory BookCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookCategory = await _context.BookCategories
                .Include(b => b.Book)
                .Include(b => b.Category).FirstOrDefaultAsync(m => m.BookId == id);

            if (BookCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
