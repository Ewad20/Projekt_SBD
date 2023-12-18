using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    [Authorize]
    public class Dodaj_wpis : PageModel
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

        public Dodaj_wpis(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult OnGet(long zwierzeId)
        {
            if (zwierzeId > 0)
            {
                ZwierzeProviderSingleton.SetZwierze(zwierzeId);
            }

            ZwierzeId = ZwierzeProviderSingleton.GetZwierze();

            FetchedKsiazeczka = _dbContext.Ksiazeczka_Zdrowia.Include(x => x.Wpis).FirstOrDefault(x => x.id_zwierzecia == ZwierzeId);

            if (FetchedKsiazeczka != null)
            {
                Wpisy = _dbContext.Wpis.Where(x => x.id_ksiazeczki == FetchedKsiazeczka.id_ksiazeczki).ToList();
                NowyWpis.id_ksiazeczki = FetchedKsiazeczka.id_ksiazeczki;
            }

            Ksiazeczka.id_zwierzecia = ZwierzeId;

            return Page();
        }

        public IActionResult OnPostNowyWpis()
        {
            long zwierzeId = ZwierzeProviderSingleton.GetZwierze();

            var ksiazeczka = _dbContext.Ksiazeczka_Zdrowia.FirstOrDefault(x => x.id_zwierzecia == zwierzeId);
            NowyWpis.data = DateTime.Now;
            NowyWpis.id_ksiazeczki = ksiazeczka.id_ksiazeczki;
            NowyWpis.Ksiazeczka = ksiazeczka;

            _dbContext.Wpis.Add(NowyWpis);
            _dbContext.SaveChangesAsync();

            return RedirectToPage("/Dodaj_wpis");
        }
    }
}
