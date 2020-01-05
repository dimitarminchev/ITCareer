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
    public class DetailsModel : PageModel
    {
        private readonly CodeFirst.Entity.CodeFirstContext _context;

        public DetailsModel(CodeFirst.Entity.CodeFirstContext context)
        {
            _context = context;
        }

        public Biography Biography { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Biography = await _context.Biographies
                .Include(b => b.Author).FirstOrDefaultAsync(m => m.Id == id);

            if (Biography == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
