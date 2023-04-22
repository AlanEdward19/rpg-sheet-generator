using RPG.SheetGenerator.Application.Commands.CreateAlignment;
using RPG.SheetGenerator.Application.Commands.Handler;
using RPG.SheetGenerator.Application.Queries.GetAlignment;
using RPG.SheetGenerator.Application.Queries.Handler;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("[controller]/v{version:apiVersion}")]
public class AlignmentController : ControllerBase
{
    private readonly CommandHandler _commandhandler;
    private readonly QueryHandler<Alignment> _queryHandler;

    public AlignmentController(CreateUpdateAlignmentCommandHandler commandHandler, GetAlignmentHandler queryHandler)
    {
        _commandhandler = new(commandHandler);
        _queryHandler = new(queryHandler);
    }

    [HttpGet("getAlignmentById")]
    public async Task<IActionResult> Get(int id) => Ok(await _queryHandler.Handle(id));

    [HttpGet("getAlignments")]
    public async Task<IActionResult> GetAll() => Ok(await _queryHandler.Handle());

    [HttpPut("updateAlignment")]
    public async Task Update([FromBody]CreateUpdateAlignmentCommand command, int id) => await _commandhandler.Handle(command, id);

    [HttpDelete("deleteAlignment")]
    public async Task Delete(int id) => await _commandhandler.Handle(id);

    [HttpPost("insertAlignment")]
    public async Task Insert([FromBody] CreateUpdateAlignmentCommand command) => await _commandhandler.Handle(command);
}