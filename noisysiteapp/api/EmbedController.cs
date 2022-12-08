

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using noisysiteapp.sitedata;

namespace noisysiteapp.api;

[ApiController]
[Route("api/[controller]")]
public class EmbedController : ControllerBase
{
    //https://blog.georgekosmidis.net/using-litedb-in-an-asp-net-core-api.html

    private ISiteDataProvider _siteDataProvider;

    public EmbedController(ISiteDataProvider siteDataProvider){
        _siteDataProvider = siteDataProvider;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
       var embeds = _siteDataProvider.GetEmbeds();
        return Ok(embeds);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {

        return Ok("a one");
    }

    [HttpPost]
    public ActionResult<Embed> Insert(Embed dto)
    {
        var success = _siteDataProvider.InsertEmbed(dto);
        if (success)
            return Ok();
        else    
            return BadRequest();
    }

}