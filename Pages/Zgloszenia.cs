using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    [Authorize]
    public class Zgloszenia : PageModel
    {
        public List<Zgloszenie_adopcyjne> Zgloszenie_Adopcyjne{ get; set; }

        private readonly SchroniskoContext _dbContext;

        public Zgloszenia(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet(long zwierzeId)
        {
            Zgloszenie_Adopcyjne = _dbContext.Zgloszenie_adopcyjne.Where(z => z.id_zwierzecia == zwierzeId).ToList();
        }
    }
}
