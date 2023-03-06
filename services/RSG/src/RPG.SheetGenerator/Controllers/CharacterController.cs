namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class CharacterController : ControllerBase
{

	public CharacterController()
	{
		
	}

    [HttpGet("getCharacterById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getCharacters")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateCharacter")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteCharacter")]
    public async Task Delete()
    {

    }

    [HttpPost("insertCharacter")]
    public async Task Insert()
    {

    }
}