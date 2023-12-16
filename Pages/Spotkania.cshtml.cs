using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    public class Spotkania : PageModel
    {
        public List<Spotkanie> spotkanie { get; set; }

        private readonly SchroniskoContext _dbContext;

        public Spotkania(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            spotkanie = _dbContext.Spotkanie.ToList();
        }
    }
}
