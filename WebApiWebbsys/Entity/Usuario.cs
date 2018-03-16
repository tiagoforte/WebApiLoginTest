using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWebbsys.Entity
{
  public class Usuario
  {
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }
  }
}
