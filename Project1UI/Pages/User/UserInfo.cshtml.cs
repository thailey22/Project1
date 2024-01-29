using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace Project1UI.Pages.User
{
    public class UserInfoModel : PageModel
    {
        public UserInfoModel(ILogger<UserInfoModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public UserInfoModel CurrentUser { get; set; } = new();
        public void OnGet()
        {
           
        }
    }
}
