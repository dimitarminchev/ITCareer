using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CHUSHKA.Models;

namespace CHUSHKA.UserPages
{
    public class IndexModel : PageModel
    {
        private readonly CHUSHKA.Models.ChushkaContext _context;

        public IndexModel(CHUSHKA.Models.ChushkaContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
