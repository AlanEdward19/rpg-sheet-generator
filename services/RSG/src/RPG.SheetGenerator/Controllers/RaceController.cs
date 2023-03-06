namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class RaceController : ControllerBase
{

	public RaceController()
	{
		
	}

    [HttpGet("getRaceById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getRaces")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateRace")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteRace")]
    public async Task Delete()
    {

    }

    [HttpPost("insertRace")]
    public async Task Insert()
    {

    }
}