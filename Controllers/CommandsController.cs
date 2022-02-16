using System.Collections.Generic;
using AutoMapper;
using Commands.Data;
using Commands.Model;
using Microsoft.AspNetCore.Mvc;

namespace Commands.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly ICommandsRepository _repository;
    private readonly IMapper _mapper;

    public CommandsController(ICommandsRepository repository,IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();

      return Ok(commandItems);
    }

    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);
      if (commandItem != null)
      {
        return Ok(commandItem);
      }
      return NotFound();
    }
  }
}