using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    public class SzczesliweZakonczenie : PageModel
    {
        [BindProperty]
        public  Szczesliwe_zakonczenie Zakonczenie { get; set; }

        [BindProperty]
        public Zdjecie Zdjecie { get; set; }

        [BindProperty]
        public long ZwierzeId { get; set; }

        private readonly SchroniskoContext _dbContext;

        public SzczesliweZakonczenie(SchroniskoContext dbContext)
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

            Zakonczenie.id_zwierzecia = zwierze.id_zwierzecia;

            Zakonczenie.Zwierze = zwierze;

            Zakonczenie.zdjecie = Zdjecie.link;

            _dbContext.Szczesliwe_Zakonczenie.Add(Zakonczenie);
            _dbContext.SaveChanges();

            return RedirectToPage("/Zakonczenia");
        }

    }
}
