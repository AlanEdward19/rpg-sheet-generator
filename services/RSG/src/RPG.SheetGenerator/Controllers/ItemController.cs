namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class ItemController : ControllerBase
{

	public ItemController()
	{
		
	}

    [HttpGet("getItemById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getItems")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateItem")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteItem")]
    public async Task Delete()
    {

    }

    [HttpPost("insertItem")]
    public async Task Insert()
    {

    }
}