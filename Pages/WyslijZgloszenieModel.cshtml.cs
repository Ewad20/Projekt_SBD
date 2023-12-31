﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    public class WyslijZgloszenieModel : PageModel
    {
        [BindProperty]
        public Zgloszenie_adopcyjne Zgloszenie { get; set; }

        [BindProperty]
        public long ZwierzeId { get; set; }

        private readonly SchroniskoContext _dbContext;

        public WyslijZgloszenieModel(SchroniskoContext dbContext)
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

            Zgloszenie.id_zwierzecia = zwierze.id_zwierzecia;

            Zgloszenie.Zwierze = zwierze;

            _dbContext.Zgloszenie_adopcyjne.Add(Zgloszenie);
            _dbContext.SaveChanges();

            return RedirectToPage("/DostepneZwierzeta");
        }
    }
}
