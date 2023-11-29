using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;
using System.Collections.Generic;

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
            Zwierzeta = _dbContext.Zwierze.ToList();
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
    }
}
