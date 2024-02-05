using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Project1UI.Models;
using System.Xml.Linq;


namespace Project1UI.Pages.User
{
    public class AddInfoModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public UserInfo CurrentUser { get; set; } = new();

        private readonly ILogger<IndexModel> _logger;

        public AddInfoModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

    

        public void OnGet()
        {
            _logger.LogInformation("OnGet from AddInfo");
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
            _logger.LogInformation("OnPost from AddInfo");
        }
    }
}
