using Domain.Responses.Glpi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.InterfacesServices.Glpi
{
    public interface IUsuarioGlpiService
    {
        Task<List<UsuarioGlpiResponse>> ListarUsuarios(string tokenGlpi);
    }
}
