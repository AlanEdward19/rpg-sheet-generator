namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class BackgroundController : ControllerBase
{

	public BackgroundController()
	{
		
	}

    [HttpGet("getBackgroundById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getBackgrounds")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateBackground")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteBackground")]
    public async Task Delete()
    {

    }

    [HttpPost("insertBackground")]
    public async Task Insert()
    {

    }
}