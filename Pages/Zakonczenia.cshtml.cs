using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace ZwierzePlus.Pages
{
    public class Zakonczenia : PageModel
    {
        public List<Szczesliwe_zakonczenie> Szczesliwe_Zakonczenia { get; set; }

        private readonly SchroniskoContext _dbContext;

        public Zakonczenia(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Szczesliwe_Zakonczenia = _dbContext.Szczesliwe_Zakonczenie.ToList();
            //  Szczesliwe_Zakonczenia = _dbContext.Szczesliwe_zakonczenie.Include(x => x.Zdjecie).ToList();

        }
        public IActionResult OnPostDelete(long id)
        {
            var zakonczenieeDoUsuniecia = _dbContext.Szczesliwe_Zakonczenie.Find(id);

            if (zakonczenieeDoUsuniecia == null)
            {
                return NotFound();
            }

            _dbContext.Szczesliwe_Zakonczenie.Remove(zakonczenieeDoUsuniecia);
            _dbContext.SaveChanges();

            return RedirectToPage("./Zakonczenia");
        }
    }
}

       