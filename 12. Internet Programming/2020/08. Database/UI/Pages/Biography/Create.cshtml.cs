using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CodeFirst.Entity;

namespace UI.BiographyPages
{
    public class CreateModel : PageModel
    {
        private readonly CodeFirst.Entity.CodeFirstContext _context;

        public CreateModel(CodeFirst.Entity.CodeFirstContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Biography Biography { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Biographies.Add(Biography);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
