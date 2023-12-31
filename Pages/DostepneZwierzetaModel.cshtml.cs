﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace ZwierzePlus.Pages
{
    public class DostepneZwierzetaModel : PageModel
    {
        public List<Zwierze> Zwierzeta { get; set; }

        private readonly SchroniskoContext _dbContext;

        public DostepneZwierzetaModel(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
			Zwierzeta = _dbContext.Zwierze.Include(x => x.Gatunek).Include(x => x.Zdjecie).ToList();
		}

        public IActionResult OnPostDelete(long id)
        {
            var zwierzeDoUsuniecia = _dbContext.Zwierze.Find(id);

            if (zwierzeDoUsuniecia == null)
            {
                return NotFound();
            }

            _dbContext.Zwierze.Remove(zwierzeDoUsuniecia);
            _dbContext.SaveChanges();

            return RedirectToPage("./DostepneZwierzeta");
        }

        public IActionResult OnPostEdit(long id)
        {
            var zwierzeDoEdycji = _dbContext.Zwierze.Find(id);

            if (zwierzeDoEdycji == null)
            {
                return NotFound();
            }

            return RedirectToPage("./EdytujZwierze", new { id = zwierzeDoEdycji.id_zwierzecia });
        }

        public IActionResult OnPostWyswietlZgloszenia(long id)
        {
            var zwierzeDoZgloszenia = _dbContext.Zwierze.Find(id);

            if (zwierzeDoZgloszenia == null)
            {
                return NotFound();
            }

            return RedirectToPage("./Zgloszenia", new { zwierzeId = zwierzeDoZgloszenia.id_zwierzecia });
        }

        public IActionResult OnPostZgloszenie(long id)
        {
            var zwierzeDoZgloszenia = _dbContext.Zwierze.Find(id);

            if (zwierzeDoZgloszenia == null)
            {
                return NotFound();
            }

            return RedirectToPage("./WyslijZgloszenie", new { zwierzeId = zwierzeDoZgloszenia.id_zwierzecia });
        }
        public IActionResult OnPostZakonczenie(long id)
        {
            var zwierzeDoZakonczenia = _dbContext.Zwierze.Find(id);

            if (zwierzeDoZakonczenia == null)
            {
                return NotFound();
            }

            return RedirectToPage("./SzczesliweZakonczenie", new { zwierzeId = zwierzeDoZakonczenia.id_zwierzecia });
        }
        public IActionResult OnPostKsiazeczka(long id)
        {
            var zwierze_ksiazeczka = _dbContext.Zwierze.Find(id);

            if (zwierze_ksiazeczka == null)
            {
                return NotFound();
            }

            return RedirectToPage("./Dodaj_ksiazeczke", new { zwierzeId = zwierze_ksiazeczka.id_zwierzecia });
        }
        public IActionResult OnPostWpisy(long id)
        {
            var zwierze_ksiazeczka = _dbContext.Zwierze.Find(id);

            if (zwierze_ksiazeczka == null)
            {
                return NotFound();
            }

            return RedirectToPage("./Dodaj_wpis", new { zwierzeId = zwierze_ksiazeczka.id_zwierzecia });
        }
        public IActionResult OnPostSpotkanie(long id)
        {
            var zwierzeDoSpotkania = _dbContext.Zwierze.Find(id);

            if (zwierzeDoSpotkania == null)
            {
                return NotFound();
            }

            return RedirectToPage("./SpotkanieAdopcyjne", new { zwierzeId = zwierzeDoSpotkania.id_zwierzecia });
        }
        public IActionResult OnPostWyswietlSpotkania(long id)
        {
            var zwierze = _dbContext.Zwierze.Find(id);

            if (zwierze == null)
            {
                return NotFound();
            }

            return RedirectToPage("./Spotkania", new { zwierzeId = zwierze.id_zwierzecia });
        }
    }
}