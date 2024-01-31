using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project1UI.Models;

namespace Project1UI.Pages.User
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public UserInfo CurrentUser { get; set; }
        public void OnGet()
        {
        }
    }
}
