using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using noisysiteapp.sitedata;

namespace noisysiteapp.Pages;

public class BlogRollModel : PageModel
{

    public List<Embed> Embeds;
    private readonly ILogger<BlogRollModel> _logger;
    private readonly ISiteDataProvider _siteDataProvider;

    public BlogRollModel(ISiteDataProvider siteDataProvider, ILogger<BlogRollModel> logger)
    {
        _logger = logger;
        _siteDataProvider=siteDataProvider;
    }

    public void OnGet()
    {
        Embeds=  _siteDataProvider.GetEmbeds().Result;
    }
}
