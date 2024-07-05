using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserApiApp.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Simulating login logic for demonstration
            if (Username == "a" && Password == "a")
            {
                // Redirect to the University page
                return RedirectToPage("/University");
            }

            // If login fails, add an error to ModelState
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");

            // Return the page with errors displayed
            return Page();
        }
    }
}
