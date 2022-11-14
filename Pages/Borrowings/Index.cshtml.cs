using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pavel_Eduard_Lab2.Data;
using Pavel_Eduard_Lab2.Models;

namespace Pavel_Eduard_Lab2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Pavel_Eduard_Lab2.Data.Pavel_Eduard_Lab2Context _context;

        public IndexModel(Pavel_Eduard_Lab2.Data.Pavel_Eduard_Lab2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                .ThenInclude(b=>b.Author)
                .Include(b => b.Member).ToListAsync();
            }
        }
    }
}
