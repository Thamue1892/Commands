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
    public IEnumerable<Command> GetAllCommands()
    {
      return _context.Commands.ToList();
    }

    public Command GetCommandById(int id)
    {
      return _context.Commands.FirstOrDefault(p => p.Id == id);
    }
  }
}