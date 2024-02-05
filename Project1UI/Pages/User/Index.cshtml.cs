using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project1UI.Models;

namespace Project1UI.Pages.User
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public UserInfo CurrentUser { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("On get was called for index");
        }

        public void OnPost()
        {
            _logger.LogInformation("On post was called for index");
        }
    }
}
