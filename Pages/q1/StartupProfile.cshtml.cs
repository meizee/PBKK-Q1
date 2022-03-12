using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace myWebApp.Pages;

public class StartupModel : PageModel
{
    private readonly ILogger<StartupModel> _logger;

    public StartupModel(ILogger<StartupModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

