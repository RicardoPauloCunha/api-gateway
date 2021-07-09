using Newtonsoft.Json;

namespace Domain.Responses.Glpi
{
    public class SessionGlpiResponse
    {
        [JsonProperty(PropertyName = "session_token")]
        public string TokenSessao { get; private set; }

        public SessionGlpiResponse(string tokenSessao)
        {
            TokenSessao = tokenSessao;
        }
    }
}
