using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace myWebApp.Pages;

public class SolutionModel : PageModel
{
    private readonly ILogger<SolutionModel> _logger;

    public SolutionModel(ILogger<SolutionModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
