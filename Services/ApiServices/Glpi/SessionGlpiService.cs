using Domain.InterfacesServices.Glpi;
using Domain.Requests.Glpi;
using Domain.Responses.Glpi;
using Refit;
using Service.InterfacesApi.Glpi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.ApiServices.Glpi
{
    public class SessionGlpiService : ISessionGlpiService
    {
        private readonly ISessionGlpiApi _sessionGlpiApi;

        public SessionGlpiService()
        {
            _sessionGlpiApi = RestService.For<ISessionGlpiApi>("http://52.234.208.15/glpi/apirest.php");
        }

        public async Task<SessionGlpiResponse> EfetuarLogin(LoginGlpiRequest loginGlpi)
        {
            // Declara a variavel sessionGlpi
            SessionGlpiResponse sessionGlpi = null;

            try
            {
                // Enviar a requisição
                sessionGlpi = await _sessionGlpiApi.EfetuarLogin(loginGlpi);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Ocorreu um erro na requisição de login no Glpi: " + ex.Message);
            }

            // Retorna o resultado
            return sessionGlpi;
        }
    }
}
