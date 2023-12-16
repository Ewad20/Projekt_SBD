using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    [Authorize]
    public class EdytujZwierzeModel : PageModel
    {
        [BindProperty]
        public Zwierze Zwierze { get; set; }

        [BindProperty]
        public Zdjecie Zdjecie { get; set; }
        public List<Gatunek> Gatunki { get; set; }

        private readonly SchroniskoContext _dbContext;

        public EdytujZwierzeModel(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult OnGet(long id)
        {
            Zwierze = _dbContext.Zwierze.Include(x => x.Gatunek).Include(x => x.Zdjecie).FirstOrDefault(z => z.id_zwierzecia == id);

            if (Zwierze == null)
            {
                return NotFound();
            }

            Gatunki = _dbContext.Gatunek.ToList();
            return Page();
        }

        public IActionResult OnPostSave(long id)
        {
            var zwierzeDoEdycji = _dbContext.Zwierze.Include(x => x.Gatunek).Include(x => x.Zdjecie).FirstOrDefault(z => z.id_zwierzecia == id);

            if (zwierzeDoEdycji == null)
            {
                return NotFound();
            }

            if (zwierzeDoEdycji.Zdjecie == null)
            {
                zwierzeDoEdycji.Zdjecie = new Zdjecie(); 
            }

            zwierzeDoEdycji.Zdjecie.link = Zwierze.Zdjecie.link;

            zwierzeDoEdycji.imie = Zwierze.imie;
            zwierzeDoEdycji.wiek = Zwierze.wiek;
            zwierzeDoEdycji.opis = Zwierze.opis;
            zwierzeDoEdycji.historia = Zwierze.historia;
            zwierzeDoEdycji.data_przyjecia = Zwierze.data_przyjecia;
            zwierzeDoEdycji.plec = Zwierze.plec;
            zwierzeDoEdycji.kastracja = Zwierze.kastracja;
            zwierzeDoEdycji.zaadoptowany = Zwierze.zaadoptowany;
            zwierzeDoEdycji.id_gatunku = Zwierze.id_gatunku;
 
          
            _dbContext.SaveChanges();

            return RedirectToPage("./DostepneZwierzeta");
        }
    }
}
