using Domain.Responses.Glpi;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.InterfacesApi.Glpi
{
    public interface IUsuarioGlpiApi
    {
        [Get("/user")]
        Task<List<UsuarioGlpiResponse>> ListarUsuarios([Header("Session-Token")] string tokenGlpi);
    }
}
