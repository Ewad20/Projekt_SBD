using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ZwierzePlus.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Konto_opiekuna Input { get; set; }

        private readonly SchroniskoContext _dbContext;

        public LoginModel(SchroniskoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var existingUser = _dbContext.Konto_opiekuna.FirstOrDefault(u => u.email == Input.email);

                if (existingUser != null)
                {
                    if (existingUser.haslo == Input.haslo)
                    {
                        return RedirectToPage("/Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Błędne hasło.");
                    }
                }
                else
                {
                    _dbContext.Konto_opiekuna.Add(Input);
                    _dbContext.SaveChanges();

                    return RedirectToPage("/Index");
                }
            }
            return Page();
        }
    }
}
