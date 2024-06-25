using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserApiApp.Models;
using UserApiApp.Services;

namespace UserApiApp.Pages
{
    public class UniversityModel : PageModel
    {
        private readonly UserService _userService;

        public UniversityModel(UserService userService)
        {
            _userService = userService;
        }

        public List<User> Users { get; private set; }

        public async Task OnGetAsync()
        {
            Users = await _userService.GetUsersAsync();
        }
    }
}
