namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class ItemTypeController : ControllerBase
{

	public ItemTypeController()
	{
		
	}

    [HttpGet("getItemTypeById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getItemTypes")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateItemType")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteItemType")]
    public async Task Delete()
    {

    }

    [HttpPost("insertItemType")]
    public async Task Insert()
    {

    }
}