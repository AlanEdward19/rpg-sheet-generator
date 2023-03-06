namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class AttributeController : ControllerBase
{

	public AttributeController()
	{
		
	}

    [HttpGet("getAttributeById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getAttributes")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateAttribute")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteAttribute")]
    public async Task Delete()
    {

    }

    [HttpPost("insertAttribute")]
    public async Task Insert()
    {

    }
}