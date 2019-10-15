using Domain.InterfacesServices.Glpi;
using Domain.Responses.Glpi;
using Refit;
using Service.InterfacesApi.Glpi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.ApiServices.Glpi
{
    public class UsuarioGlpiService : IUsuarioGlpiService
    {
        private readonly IUsuarioGlpiApi _usuarioGlpiService;

        public UsuarioGlpiService()
        {
            _usuarioGlpiService = RestService.For<IUsuarioGlpiApi>("http://52.234.208.15/glpi/apirest.php");
        }

        public async Task<List<UsuarioGlpiResponse>> ListarUsuarios(string tokenGlpi)
        {
            // Declara a variavel sessionGlpi
            List<UsuarioGlpiResponse> usuarios = null;

            try
            {
                // Enviar a requisição
                usuarios = await _usuarioGlpiService.ListarUsuarios(tokenGlpi);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Ocorreu um erro na requisição de login no Glpi: " + ex.Message);
            }

            // Retorna o resultado
            return usuarios;
        }
    }
}
