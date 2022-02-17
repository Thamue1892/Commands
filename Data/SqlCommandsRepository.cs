using System.Collections.Generic;
using System.Linq;
using Commands.Model;

namespace Commands.Data
{
  public class SqlCommandsRepository : ICommandsRepository
  {
    private readonly CommandsContext _context;
    public SqlCommandsRepository(CommandsContext context)
    {
      _context = context;
    }

    public void CreateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands()
    {
      return _context.Commands.ToList();
    }

    public Command GetCommandById(int id)
    {
      return _context.Commands.FirstOrDefault(p => p.Id == id);
    }

    public bool SaveChanges()
    {
      return(_context.SaveChanges() >= 0);
    }
  }
}