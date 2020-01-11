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
    public class DeleteModel : PageModel
    {
        private readonly CodeFirst.Entity.CodeFirstContext _context;

        public DeleteModel(CodeFirst.Entity.CodeFirstContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Biography = await _context.Biographies.FindAsync(id);

            if (Biography != null)
            {
                _context.Biographies.Remove(Biography);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
