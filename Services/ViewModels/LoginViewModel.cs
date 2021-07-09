using System.ComponentModel.DataAnnotations;

namespace Service.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail(login GLPI).")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha.")]
        public string Senha { get; set; }
    }
}
