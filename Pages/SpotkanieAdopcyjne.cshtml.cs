using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    [Authorize]
    public class SpotkanieAdopcyjne : PageModel
    {
        [BindProperty]
        public Spotkanie spotkanie { get; set; }

        [BindProperty]
        public long ZwierzeId { get; set; }

        private readonly SchroniskoContext _dbContext;

        public SpotkanieAdopcyjne(SchroniskoContext dbContext)
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

            spotkanie.id_zwierzecia = zwierze.id_zwierzecia;

            spotkanie.Zwierze = zwierze;

            _dbContext.Spotkanie.Add(spotkanie);
            _dbContext.SaveChanges();

            return RedirectToPage("/DostepneZwierzeta");
        }
    }
}
