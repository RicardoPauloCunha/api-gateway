using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
