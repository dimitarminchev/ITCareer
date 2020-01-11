using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Entity;

namespace UI.AuthorPages
{
    public class EditModel : PageModel
    {
        private readonly CodeFirst.Entity.CodeFirstContext _context;

        public EditModel(CodeFirst.Entity.CodeFirstContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Author = await _context.Authors.FirstOrDefaultAsync(m => m.Id == id);

            if (Author == null)
            {
                return NotFound();
            }
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

            _context.Attach(Author).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(Author.Id))
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

        private bool AuthorExists(int id)
        {
            return _context.Authors.Any(e => e.Id == id);
        }
    }
}
