using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CHUSHKA.Models;

namespace CHUSHKA.OrderPages
{
    public class IndexModel : PageModel
    {
        private readonly CHUSHKA.Models.ChushkaContext _context;

        public IndexModel(CHUSHKA.Models.ChushkaContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Orders
                .Include(o => o.Product)
                .Include(o => o.User).ToListAsync();
        }
    }
}
