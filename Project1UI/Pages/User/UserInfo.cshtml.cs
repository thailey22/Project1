using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace Project1UI.Pages.User
{
    public class UserInfoModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public UserInfoModel CurrentUser { get; set; } = new();

        private readonly ILogger<IndexModel> _logger;

        public AddInfoModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

    

        public void OnGet()
        {
           
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("./Index", CurrentUser);

            }

            else
            {
                return Page();
            }
        }
    }
}
