using Domain.Requests.Glpi;
using Domain.Responses.Glpi;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.InterfacesApi.Glpi
{
    public interface ISessionGlpiApi
    {
        [Post("/initSession")]
        Task<SessionGlpiResponse> EfetuarLogin([Body]LoginGlpiRequest loginGlpi);
    }
}
