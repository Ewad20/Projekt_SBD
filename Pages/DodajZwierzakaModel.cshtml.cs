using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ZwierzePlus.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data.Entity;

namespace ZwierzePlus.Pages
{
    [Authorize]
    public class DodajZwierzakaModel : PageModel
    {
        [BindProperty]
        public Zwierze Zwierze { get; set; }
        [BindProperty]
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
            Zwierze.Zdjecie = Zdjecie;
            EntityEntry<Zdjecie> image = _dbContext.Add(Zdjecie);

            Zwierze.id_zdjecia = image.Entity.id_zdjecia;

         
            _dbContext.Add(Zwierze);
            _dbContext.SaveChanges();

            var dostepneZwierzeta = _dbContext.Zwierze.Include(x => x.Zdjecie).ToList();

            return RedirectToPage("/DostepneZwierzeta", new { zwierzeta = dostepneZwierzeta });
            

            return Page();
        }
    }
}
