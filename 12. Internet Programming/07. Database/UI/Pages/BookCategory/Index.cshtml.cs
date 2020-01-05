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
    public class IndexModel : PageModel
    {
        private readonly CodeFirst.Entity.CodeFirstContext _context;

        public IndexModel(CodeFirst.Entity.CodeFirstContext context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; }

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategories
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
