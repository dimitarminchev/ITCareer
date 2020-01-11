using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Entity;

namespace UI.BiographyPages
{
    public class EditModel : PageModel
    {
        private readonly CodeFirst.Entity.CodeFirstContext _context;

        public EditModel(CodeFirst.Entity.CodeFirstContext context)
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
           ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Biography).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BiographyExists(Biography.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BiographyExists(int id)
        {
            return _context.Biographies.Any(e => e.Id == id);
        }
    }
}
