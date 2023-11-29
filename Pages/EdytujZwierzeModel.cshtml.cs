using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    public class EdytujZwierzeModel : PageModel
    {
        [BindProperty]
        public Zwierze Zwierze { get; set; }

        private readonly SchroniskoContext _dbContext;

        public EdytujZwierzeModel(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult OnGet(long id)
        {
            Zwierze = _dbContext.Zwierze.Find(id);

            if (Zwierze == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPostSave(long id)
        {
            var zwierzeDoEdycji = _dbContext.Zwierze.Find(id);

            if (zwierzeDoEdycji == null)
            {
                return NotFound();
            }

            zwierzeDoEdycji.imie = Zwierze.imie;
            zwierzeDoEdycji.wiek = Zwierze.wiek;
            zwierzeDoEdycji.opis = Zwierze.opis;
            zwierzeDoEdycji.historia = Zwierze.historia;
            zwierzeDoEdycji.data_przyjecia = Zwierze.data_przyjecia;
            zwierzeDoEdycji.plec = Zwierze.plec;
            zwierzeDoEdycji.kastracja = Zwierze.kastracja;
            zwierzeDoEdycji.zaadoptowany = Zwierze.zaadoptowany;


            _dbContext.SaveChanges();

            return RedirectToPage("./DostepneZwierzeta");
        }
    }
}
