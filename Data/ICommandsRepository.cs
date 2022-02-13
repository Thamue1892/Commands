using System.Collections.Generic;
using Commands.Models;

namespace Commands.Data 
{
  public interface ICommandsRepository 
  {
    IEnumerable<Command> GetAppCommands ();
    Command GetCommandById (int id);
  }
}
