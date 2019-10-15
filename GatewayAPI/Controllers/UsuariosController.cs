using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.InterfacesServices.Glpi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.ApiServices.Glpi;

namespace GatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioGlpiService _usuarioGlpiService;

        public UsuariosController()
        {
            _usuarioGlpiService = new UsuarioGlpiService();
        }

        [HttpGet]
        public IActionResult ListarUsuarios()
        {
            try
            {
                // Pega a sessão GLPI do usuario
                string tokenGlpi = User.FindFirst("sessionTokenGlpi")?.Value;

                // Verifica se o token foi encontrado
                if (tokenGlpi == null)
                {
                    // Retorna 401
                    return Unauthorized();
                }

                // Lista os usuarios do glpi
                var usuarios = _usuarioGlpiService.ListarUsuarios(tokenGlpi).Result;

                //Retorna Ok com o Token
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.InnerException.Message });
            }
        }
    }
}