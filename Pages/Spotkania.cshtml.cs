using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    [Authorize]
    public class Spotkania : PageModel
    {
        public List<Spotkanie> spotkanie { get; set; }

        private readonly SchroniskoContext _dbContext;

        public Spotkania(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet(long zwierzeId)
        {
            spotkanie = _dbContext.Spotkanie.Where(z => z.id_zwierzecia == zwierzeId).ToList();
        }
    }
}
