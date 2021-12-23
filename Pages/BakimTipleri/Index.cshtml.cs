using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SeGCore3._1Project.Data;
using SeGCore3._1Project.Models;

namespace SeGCore3._1Project.Pages.BakimTipleri
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IList<BakimTipi> BakimTipi { get; set; }
        public async Task<IActionResult> OnGet()
        {
            BakimTipi= await _db.BakimTipi.ToListAsync();
            return Page();
        }
    }
}
