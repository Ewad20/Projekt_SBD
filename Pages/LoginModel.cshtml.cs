using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZwierzePlus.Model;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _dbContext.Konto_opiekuna.FirstOrDefaultAsync(u => u.email == Input.email);

                if (existingUser != null)
                {
                    if (existingUser.haslo == Input.haslo)
                    {
                        var claims = new[]
                        {
                            new Claim(ClaimTypes.Name, existingUser.email),
                        };

                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            principal);

                        return RedirectToPage("/Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Błędne hasło.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Nieprawidłowy użytkownik.");
                }
            }
            return Page();
        }
    }
}
