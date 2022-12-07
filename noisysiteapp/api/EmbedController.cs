

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace noisysiteapp.api;

[ApiController]
[Route("api/[controller]")]
public class EmbedController : ControllerBase
{

    [HttpGet]
    public IActionResult GetAll()
    {
        List<Embed> embeds = new List<Embed>();
        embeds.Add(new Embed{Id="1234", Subject="music", Link="https://test.com", Content="<h1>content here </h1>"});
        embeds.Add(new Embed{Id="4321", Subject="music", Link="https://test.com/22", Content="<h1>more content here </h1>"});
        return Ok(embeds);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {

        return Ok("a one");
    }
}