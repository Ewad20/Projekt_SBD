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

            if (zwierzeDoEdycji.Zdjecie == null)
            {
                zwierzeDoEdycji.Zdjecie = new Zdjecie(); 
            }

            zwierzeDoEdycji.Zdjecie.link = Zdjecie?.link;

            zwierzeDoEdycji.imie = Zwierze.imie;
            zwierzeDoEdycji.wiek = Zwierze.wiek;
            zwierzeDoEdycji.opis = Zwierze.opis;
            zwierzeDoEdycji.historia = Zwierze.historia;
            zwierzeDoEdycji.data_przyjecia = Zwierze.data_przyjecia;
            zwierzeDoEdycji.plec = Zwierze.plec;
            zwierzeDoEdycji.kastracja = Zwierze.kastracja;
            zwierzeDoEdycji.zaadoptowany = Zwierze.zaadoptowany;
            zwierzeDoEdycji.Zdjecie.link = Zdjecie.link;

            _dbContext.SaveChanges();

            return RedirectToPage("./DostepneZwierzeta");
        }
    }
}
