using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    public class Dodaj_ksiazeczke : PageModel
    {
        [BindProperty]
        public Ksiazeczka_zdrowia Ksiazeczka { get; set; }

        [BindProperty]
        public long ZwierzeId { get; set; }

        private readonly SchroniskoContext _dbContext;

        public Dodaj_ksiazeczke(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            var zwierze = _dbContext.Zwierze.Find(ZwierzeId);

            if (zwierze == null)
            {
                return NotFound();
            }

            Ksiazeczka.id_zwierzecia = zwierze.id_zwierzecia;

            Ksiazeczka.Zwierze = zwierze;

            _dbContext.Ksiazeczka_Zdrowia.Add(Ksiazeczka);
            _dbContext.SaveChanges();

            return RedirectToPage("/DostepneZwierzeta");
        }
    }
}
