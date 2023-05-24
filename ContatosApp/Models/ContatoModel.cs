using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ContatosApp.Models
{
	public class ContatoModel
	{
        public int id { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório")]
		[StringLength(50,MinimumLength = 6, ErrorMessage = "O nome deve ter no mínimo 6 caracteres.")]
		public string nome { get; set; }

		[Required(ErrorMessage ="Campo Obrigatório")]
		[StringLength(9, MinimumLength = 9, ErrorMessage = "O campo deve ter 9 caracteres.")]
		public string telefone { get; set; }

		[Required (ErrorMessage ="Insira um Email Valido")]
		public string email { get; set; }
    }
}
