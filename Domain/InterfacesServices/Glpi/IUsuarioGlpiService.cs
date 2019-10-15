using Domain.Responses.Glpi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InterfacesServices.Glpi
{
    public interface IUsuarioGlpiService
    {
        Task<List<UsuarioGlpiResponse>> ListarUsuarios(string tokenGlpi);
    }
}
