using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWebbsys.Command;
using WebApiWebbsys.Data;
using WebApiWebbsys.Interface;

namespace WebApiWebbsys.Repository
{
  public class UsuarioRepository : IUsuarioRepository
  {
    private DataContext _context;

    public UsuarioRepository(DataContext context)
    {
      _context = context;

    }

    public string Autenticar(LoginCommand loginCommand)
    {
      var usuario = this._context.Usuario.FirstOrDefault();
      return (usuario.Email.Equals(loginCommand.usuario) && usuario.Email.Equals(loginCommand.usuario)) ? usuario.Nome : "Usuário ou senha inválidos";
    }

  }
}
