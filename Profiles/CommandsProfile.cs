using AutoMapper;
using Commands.Dtos;
using Commands.Model;

namespace Commands.Profiles
{
  public class CommandsProfile:Profile
  {
    public CommandsProfile()
    {
      CreateMap<Command, CommandReadDto>();
    }
  }
}