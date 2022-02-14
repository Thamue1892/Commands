using System.Collections.Generic;
using Commands.Data;
using Commands.Model;
using Microsoft.AspNetCore.Mvc;

namespace Commands.Controllers
{

  [Route ("api/[controller]")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly ICommandsRepository _repository;

    public CommandsController (ICommandsRepository repository)
    {
      _repository = repository;

    }
    //private readonly MockCommandsRepository _repository = new MockCommandsRepository ();

    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands ()
    {
      var commandItems = _repository.GetAppCommands ();

      return Ok (commandItems);
    }

    [HttpGet ("{id}")]
    public ActionResult<Command> GetCommandById (int id)
    {
      var commandItem = _repository.GetCommandById (id);
      return Ok (commandItem);
    }
  }
}