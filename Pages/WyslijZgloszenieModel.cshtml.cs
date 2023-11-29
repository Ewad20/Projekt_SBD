using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    public class WyslijZgloszenieModel : PageModel
    {
        [BindProperty]
        public Zgloszenie_adopcyjne Zgloszenie { get; set; }

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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _dbContext.Zgloszenie_adopcyjne.Add(Zgloszenie);
            _dbContext.SaveChanges();

            return RedirectToPage("/DostepneZwierzeta");
        }
    }
}
