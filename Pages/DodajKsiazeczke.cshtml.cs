using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    [Authorize]
    public class DodajKsiazeczke : PageModel
    {
        [BindProperty]
        public Ksiazeczka_zdrowia Ksiazeczka { get; set; } = new();

        [BindProperty]
        public long ZwierzeId { get; set; }

        private readonly SchroniskoContext _dbContext;

        [BindProperty]
        public Wpis NowyWpis { get; set; } = new();

        public Ksiazeczka_zdrowia FetchedKsiazeczka { get; set; }

        public List<Wpis> Wpisy { get; set; }

        public DodajKsiazeczke(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult OnGet(long zwierzeId)
        {
            ZwierzeId = zwierzeId;
            FetchedKsiazeczka = _dbContext.Ksiazeczka_Zdrowia.FirstOrDefault(x => x.id_zwierzecia == ZwierzeId);

            if (FetchedKsiazeczka != null)
            {
                Wpisy = _dbContext.Wpis.Where(x => x.id_ksiazeczki == FetchedKsiazeczka.id_ksiazeczki).ToList();
                NowyWpis.id_ksiazeczki = FetchedKsiazeczka.id_ksiazeczki;
            }

            Ksiazeczka.id_zwierzecia = ZwierzeId;

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

        public IActionResult OnPostWpis()
        {
            NowyWpis.data = DateTime.Now;

            _dbContext.Wpis.Add(NowyWpis);

            return Page();
        }
    }
}
