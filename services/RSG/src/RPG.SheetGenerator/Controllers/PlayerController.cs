namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class PlayerController : ControllerBase
{

	public PlayerController()
	{
		
	}

    [HttpGet("getPlayerById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getPlayers")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updatePlayer")]
    public async Task Update()
    {

    }

    [HttpDelete("deletePlayer")]
    public async Task Delete()
    {

    }

    [HttpPost("insertPlayer")]
    public async Task Insert()
    {

    }
}