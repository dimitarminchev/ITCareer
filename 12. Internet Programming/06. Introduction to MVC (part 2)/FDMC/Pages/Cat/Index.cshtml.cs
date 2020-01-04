using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FDMC.Models;

namespace FDMC
{
    public class IndexModel : PageModel
    {
        private readonly FDMC.Models.CatContext _context;

        public IndexModel(FDMC.Models.CatContext context)
        {
            _context = context;
        }

        public IList<Cat> Cat { get;set; }

        public async Task OnGetAsync()
        {
            Cat = await _context.Cats.ToListAsync();
        }
    }
}
