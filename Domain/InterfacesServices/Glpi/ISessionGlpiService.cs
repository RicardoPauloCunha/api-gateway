using Domain.Requests.Glpi;
using Domain.Responses.Glpi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InterfacesServices.Glpi
{
    public interface ISessionGlpiService
    {
        Task<SessionGlpiResponse> EfetuarLogin(LoginGlpiRequest loginGlpi);
    }
}
