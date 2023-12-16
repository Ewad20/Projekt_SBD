using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ZwierzePlus.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ZwierzePlus.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Konto_opiekuna Konto { get; set; }
        [BindProperty]
        public Opiekun Opiekun { get; set; }

        private readonly SchroniskoContext _dbContext;

        public RegisterModel(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var opiekun = _dbContext.Opiekun.FirstOrDefault(o =>
                o.imie == Opiekun.imie &&
                o.nazwisko == Opiekun.nazwisko &&
                o.kod == Opiekun.kod
            );

            if (opiekun != null)
            {
                var noweKonto = new Konto_opiekuna
                {
                    email = Konto.email,
                    telefon = Konto.telefon,
                    haslo = Konto.haslo
                };

                _dbContext.Konto_opiekuna.Add(noweKonto);
                _dbContext.SaveChanges();

                return RedirectToPage("/Login");
            }

            ModelState.AddModelError(string.Empty, "Nieprawid³owe dane weryfikacyjne.");
            return Page();
        }
    }
}
