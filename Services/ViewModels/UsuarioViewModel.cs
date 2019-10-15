using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.ViewModels
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "Informe o logon do usuário")]
        public string Logon { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe confirme a senha do usuário")]
        public string Senha2 { get; set; }

        [Required(ErrorMessage = "Informe o primeiro nome do usuário")]
        public string PrimeiroNome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome do usuário")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o Telefone do usuário")]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Informe o perfil do usuário")]
        public int PerfilId { get; set; }

        [Required(ErrorMessage = "Informe a entidade que o usuário fará parte")]
        public int EntidadeId { get; set; }
    }
}
