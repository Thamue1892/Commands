using System.ComponentModel.DataAnnotations;

namespace Commands.Dtos
{
  public class CommandUpdateDto
  {
    [Required]
    [MaxLength(250)]
    public string HowTo { get; set; }

    [Required]
     public string Line { get; set; }

    [Required]
    public string Platform { get; set; }
    
  }

}