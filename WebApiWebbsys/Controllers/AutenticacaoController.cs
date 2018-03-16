using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiWebbsys.Command;
using WebApiWebbsys.Interface;

namespace WebApiWebbsys.Controllers
{

  [Route("v1/")]
  public class AutenticacaoController : Controller
  {
    private IUsuarioRepository _usuarioRepository;

    public AutenticacaoController(IUsuarioRepository usuarioRepository)
    {
      this._usuarioRepository = usuarioRepository;
    }


    [HttpPost]
    [Route("autenticar")]
    public async Task<IActionResult> Post([FromBody]LoginCommand logiCommand)
    {

      return new OkObjectResult(new { result = _usuarioRepository.Autenticar(logiCommand) });
    }

  }
}
