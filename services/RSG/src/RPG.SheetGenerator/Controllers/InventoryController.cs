namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class InventoryController : ControllerBase
{

	public InventoryController()
	{
		
	}

    [HttpGet("getInventoryById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getInventories")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateInventory")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteInventory")]
    public async Task Delete()
    {

    }

    [HttpPost("insertInventory")]
    public async Task Insert()
    {

    }
}