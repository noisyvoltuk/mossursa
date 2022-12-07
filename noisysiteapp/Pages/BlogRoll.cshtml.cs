using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace noisysiteapp.Pages;

public class BlogRollModel : PageModel
{
    private readonly ILogger<BlogRollModel> _logger;

    public BlogRollModel(ILogger<BlogRollModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
