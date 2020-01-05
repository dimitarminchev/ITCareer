using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Entity;

namespace UI.BiographyPages
{
    public class IndexModel : PageModel
    {
        private readonly CodeFirst.Entity.CodeFirstContext _context;

        public IndexModel(CodeFirst.Entity.CodeFirstContext context)
        {
            _context = context;
        }

        public IList<Biography> Biography { get;set; }

        public async Task OnGetAsync()
        {
            Biography = await _context.Biographies
                .Include(b => b.Author).ToListAsync();
        }
    }
}
