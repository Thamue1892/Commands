using System.Collections.Generic;
using Commands.Model;

namespace Commands.Data
{
  public interface ICommandsRepository 
  {
    IEnumerable<Command> GetAllCommands();
    Command GetCommandById (int id);
    void CreateCommand(Command cmd);
    void UpdateCommand(Command cmd);
    void DeleteCommand(Command cmd);
    bool SaveChanges();
  }
}
