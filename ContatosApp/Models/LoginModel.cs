using System.ComponentModel.DataAnnotations;

namespace ContatosApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Usuário é obrigatorio")]
        public string usuario { get; set; }
        [Required(ErrorMessage = "Senha é obrigatorio")]
        public string senha { get; set; }
    }
}
