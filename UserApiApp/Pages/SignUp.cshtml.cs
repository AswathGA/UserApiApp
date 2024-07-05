using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserApiApp.Pages
{
    public class SignUpModel : PageModel
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
            // Add your signup logic here
            return RedirectToPage("/University");
        }
    }
}
