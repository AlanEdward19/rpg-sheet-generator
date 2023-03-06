namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class ClassController : ControllerBase
{

	public ClassController()
	{
		
	}

    [HttpGet("getClassById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getClasses")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateClass")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteClass")]
    public async Task Delete()
    {

    }

    [HttpPost("insertClass")]
    public async Task Insert()
    {

    }
}