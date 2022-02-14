using System.Collections.Generic;
using Commands.Model;

namespace Commands.Data
{
  public interface ICommandsRepository 
  {
    IEnumerable<Command> GetAppCommands ();
    Command GetCommandById (int id);
  }
}
