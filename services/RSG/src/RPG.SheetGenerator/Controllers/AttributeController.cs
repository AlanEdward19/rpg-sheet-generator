using RPG.SheetGenerator.Application.Commands.CreateUpdateAttribute;
using RPG.SheetGenerator.Application.Commands.Handler;
using RPG.SheetGenerator.Application.Queries.GetAttribute;
using RPG.SheetGenerator.Application.Queries.Handler;
using Attribute = RPG.SheetGenerator.Core.Entities.Attribute;

namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class AttributeController : ControllerBase
{
    private readonly CommandHandler _commandhandler;
    private readonly QueryHandler<Attribute> _queryHandler;

    public AttributeController(CreateUpdateAttributeCommandHandler commandHandler, GetAttributeHandler queryHandler)
    {
        _commandhandler = new(commandHandler);
        _queryHandler = new(queryHandler);
    }

    [HttpGet("getAttributeById")]
    public async Task<IActionResult> Get(int id) => Ok(await _queryHandler.Handle(id));

    [HttpGet("getAttributes")]
    public async Task<IActionResult> GetAll() => Ok(await _queryHandler.Handle());

    [HttpPut("updateAttribute")]
    public async Task Update([FromBody] CreateUpdateAttributeCommand command, int id) => await _commandhandler.Handle(command, id);

    [HttpDelete("deleteAttribute")]
    public async Task Delete(int id) => await _commandhandler.Handle(id);

    [HttpPost("insertAttribute")]
    public async Task Insert([FromBody] CreateUpdateAttributeCommand command) => await _commandhandler.Handle(command);
}