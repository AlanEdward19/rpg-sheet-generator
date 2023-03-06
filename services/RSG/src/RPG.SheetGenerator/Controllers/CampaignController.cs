namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class CampaignController : ControllerBase
{

	public CampaignController()
	{
		
	}

    [HttpGet("getCampaignById")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpGet("getCampaigns")]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

    [HttpPut("updateCampaign")]
    public async Task Update()
    {

    }

    [HttpDelete("deleteCampaign")]
    public async Task Delete()
    {

    }

    [HttpPost("insertCampaign")]
    public async Task Insert()
    {

    }
}