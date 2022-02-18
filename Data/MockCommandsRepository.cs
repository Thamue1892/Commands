using System.Collections;
using System.Collections.Generic;
using Commands.Model;

namespace Commands.Data
{
  public class MockCommandsRepository : ICommandsRepository
  {
    public void CreateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands ()
    {
      var Commands = new List<Command>
      {
        new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kettle & pan" },
        new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "kettle & pan" },
        new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "kettle & cup" }
      };

      return Commands;
    }

    public Command GetCommandById (int id)
    {
      return new Command
      {
        Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kettle & pan"    
      };
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }
  }
}