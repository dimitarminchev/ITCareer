using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Entity;

namespace UI.BookPages
{
    public class IndexModel : PageModel
    {
        private readonly CodeFirst.Entity.CodeFirstContext _context;

        public IndexModel(CodeFirst.Entity.CodeFirstContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books
                .Include(b => b.Author).ToListAsync();
        }
    }
}
