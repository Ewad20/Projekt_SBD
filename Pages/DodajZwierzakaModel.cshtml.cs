using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ZwierzePlus.Model;
using System.Collections.Generic;
using System.Linq;

namespace ZwierzePlus.Pages
{
    public class DodajZwierzakaModel : PageModel
    {
        [BindProperty]
        public Zwierze Zwierze { get; set; }
        public Zdjecie Zdjecie { get; set; }

        private readonly SchroniskoContext _dbContext;

        public DodajZwierzakaModel(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(Zwierze);
                _dbContext.SaveChanges();

                var dostepneZwierzeta = _dbContext.Zwierze.ToList();

                return RedirectToPage("/DostepneZwierzeta", new { zwierzeta = dostepneZwierzeta });
            }

            return Page();
        }
    }
}
