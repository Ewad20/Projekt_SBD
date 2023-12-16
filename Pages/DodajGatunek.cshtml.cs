using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ZwierzePlus.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data.Entity;
using System.Drawing;

namespace ZwierzePlus.Pages
{
    [Authorize]
    public class DodajGatunekModel : PageModel
    {
        [BindProperty]
        public Gatunek Gatunek { get; set; }
        public List<Gatunek> Gatunki { get; set; }

        private readonly SchroniskoContext _dbContext;

        public DodajGatunekModel(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Gatunki = _dbContext.Gatunek.ToList();
        }
        public IActionResult OnPostDelete(long id)
        {
            var gatunekDoUsuniecia = _dbContext.Gatunek.Find(id);

            if (gatunekDoUsuniecia == null)
            {
                return NotFound();
            }

            _dbContext.Gatunek.Remove(gatunekDoUsuniecia);
            _dbContext.SaveChanges();

            return RedirectToPage("./DodajGatunek");
        }

        public IActionResult OnPost()
        {
            var nowyGatunek = new Gatunek
            {
                nazwa = Gatunek.nazwa,
                typ_rasy = Gatunek.typ_rasy,
                max_wysokosc = Gatunek.max_wysokosc
            };


            _dbContext.Add(Gatunek);
            _dbContext.SaveChanges();

            TempData["SuccessMessage"] = "Gatunek zosta� dodany pomy�lnie.";

            return RedirectToPage("/DodajGatunek");
        }
    }
}
