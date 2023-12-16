using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;

namespace ZwierzePlus.Pages
{
    public class Zgloszenia : PageModel
    {
        public List<Zgloszenie_adopcyjne> Zgloszenie_Adopcyjne{ get; set; }

        private readonly SchroniskoContext _dbContext;

        public Zgloszenia(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Zgloszenie_Adopcyjne = _dbContext.Zgloszenie_adopcyjne.ToList();
        }
    }
}
