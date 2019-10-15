using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.InterfacesServices.Glpi;
using Domain.Requests.Glpi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Service.ApiServices.Glpi;
using Service.ViewModels;

namespace GatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ISessionGlpiService _sessionGlpiService;

        public SessionController()
        {
            _sessionGlpiService = new SessionGlpiService();
        }

        [HttpPost("/api/login")]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                // Declara o objeto de login do Glpi
                LoginGlpiRequest loginGlpiRequest = new LoginGlpiRequest(login.Email, login.Senha);

                // Efetua Login no Glpi
                var sessionGlpiResponse = _sessionGlpiService.EfetuarLogin(loginGlpiRequest).Result;

                // Verifica se a requisição ocorreu com sucesso
                if (sessionGlpiResponse == null)
                {
                    return NotFound();
                }

                //Define os dados que serão fornecidos no token - PayLoad
                var claims = new[]
                {
                    new Claim("sessionTokenGlpi", sessionGlpiResponse.TokenSessao.ToString()),
                };

                // Chave de acesso do token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("gateaway-chave-autenticacao"));

                //Credenciais do Token - Header
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //Gera o token
                var token = new JwtSecurityToken(
                    issuer: "GatewayAPI.WebApi",
                    audience: "GatewayAPI.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds
                );

                //Retorna Ok com o Token
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.InnerException != null ? $"{ex.InnerException.Message}": ex.Message });
            }
        }
    }
}