using ContatosApp.Enums;

namespace ContatosApp.Models
{
	public class UsuarioModel
	{
        public int id { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public PerfilEnum perfil { get; set; }

        public bool ValidarSenha(string _senha) {

            return senha == _senha;
        }
    }
}
