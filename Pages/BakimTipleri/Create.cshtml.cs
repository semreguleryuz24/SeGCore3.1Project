using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeGCore3._1Project.Data;
using SeGCore3._1Project.Models;

namespace SeGCore3._1Project.Pages.BakimTipleri
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public BakimTipi BakimTipi { get; set; }
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {  
                return Page();
            }
            _db.BakimTipi.Add(BakimTipi);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");

        }


        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
