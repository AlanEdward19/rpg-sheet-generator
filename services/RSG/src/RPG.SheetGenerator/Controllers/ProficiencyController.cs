namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class ProficiencyController : ControllerBase
{

	public ProficiencyController()
	{
		
	}

    [HttpGet("getProficiencyById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getProficiencies")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateProficiency")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteProficiency")]
    public async Task Delete()
    {

    }

    [HttpPost("insertProficiency")]
    public async Task Insert()
    {

    }
}