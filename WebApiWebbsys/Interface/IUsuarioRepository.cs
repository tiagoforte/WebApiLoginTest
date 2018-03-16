using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWebbsys.Command;

namespace WebApiWebbsys.Interface
{
  public interface IUsuarioRepository
  {
    string Autenticar(LoginCommand loginCommand);
  }

}
