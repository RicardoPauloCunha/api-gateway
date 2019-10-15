using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Responses.Glpi
{
    public class UsuarioGlpiResponse
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; private set; }

        [JsonProperty(PropertyName = "name")]
        public string Logon { get; private set; }

        [JsonProperty(PropertyName = "realname")]
        public string PrimeiroNome { get; private set; }

        [JsonProperty(PropertyName = "firstname")]
        public string Sobrenome { get; private set; }

        [JsonProperty(PropertyName = "profiles_id")]
        public int ProfileId { get; private set; }

        [JsonProperty(PropertyName = "entities_id")]
        public int EntidadeId { get; private set; }

        [JsonProperty(PropertyName = "usertitles_id")]
        public int TituloUsuarioId { get; private set; }

        [JsonProperty(PropertyName = "usercategories_id")]
        public int CategoriaUsuario { get; private set; }

        [JsonProperty(PropertyName = "phone")]
        public string Telefone { get; private set; }

        [JsonProperty(PropertyName = "phone2")]
        public string Telefone2 { get; private set; }

        [JsonProperty(PropertyName = "mobile")]
        public string Celular { get; private set; }

        [JsonProperty(PropertyName = "authtype")]
        public int TipoAutorizacaoId { get; private set; }

        public UsuarioGlpiResponse(int id, string logon, string primeiroNome, string sobrenome, int profileId, int entidadeId, int tituloUsuarioId, int categoriaUsuario, string telefone, string telefone2, string celular, int tipoAutorizacaoId)
        {
            Id = id;
            Logon = logon;
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            ProfileId = profileId;
            EntidadeId = entidadeId;
            TituloUsuarioId = tituloUsuarioId;
            CategoriaUsuario = categoriaUsuario;
            Telefone = telefone;
            Telefone2 = telefone2;
            Celular = celular;
            TipoAutorizacaoId = tipoAutorizacaoId;
        }
    }
}
