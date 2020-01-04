using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FDMC.Models;

namespace FDMC
{
    public class CreateModel : PageModel
    {
        private readonly FDMC.Models.CatContext _context;

        public CreateModel(FDMC.Models.CatContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cat Cat { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cats.Add(Cat);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
