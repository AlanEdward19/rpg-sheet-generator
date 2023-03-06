namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class LanguageController : ControllerBase
{

	public LanguageController()
	{
		
	}

    [HttpGet("getLanguageById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getLanguages")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateLanguage")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteLanguage")]
    public async Task Delete()
    {

    }

    [HttpPost("insertLanguage")]
    public async Task Insert()
    {

    }
}