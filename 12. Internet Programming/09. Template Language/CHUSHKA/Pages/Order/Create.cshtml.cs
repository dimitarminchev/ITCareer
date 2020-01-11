using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CHUSHKA.Models;

namespace CHUSHKA.OrderPages
{
    public class CreateModel : PageModel
    {
        private readonly CHUSHKA.Models.ChushkaContext _context;

        public CreateModel(CHUSHKA.Models.ChushkaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
        ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
