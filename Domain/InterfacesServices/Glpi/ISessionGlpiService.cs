using Domain.Requests.Glpi;
using Domain.Responses.Glpi;
using System.Threading.Tasks;

namespace Domain.InterfacesServices.Glpi
{
    public interface ISessionGlpiService
    {
        Task<SessionGlpiResponse> EfetuarLogin(LoginGlpiRequest loginGlpi);
    }
}
