namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class AlignmentController : ControllerBase
{

	public AlignmentController()
	{
		
	}

    [HttpGet("getAlignmentById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getAlignments")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateAlignment")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteAlignment")]
    public async Task Delete()
    {

    }

    [HttpPost("insertAlignment")]
    public async Task Insert()
    {

    }
}