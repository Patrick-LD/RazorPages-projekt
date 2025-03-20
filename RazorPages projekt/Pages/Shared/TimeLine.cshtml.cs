using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_projekt.Pages.Shared
{
    public class TimeLineModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public TimeLineModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}

