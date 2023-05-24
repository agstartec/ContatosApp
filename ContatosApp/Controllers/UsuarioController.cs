using ContatosApp.Models;
using ContatosApp.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ContatosApp.Controllers
{
	public class UsuarioController : Controller
	{
		private readonly IUsuariosRepositorio _usuarioRepositorio;
		public UsuarioController(IUsuariosRepositorio usuariosRepositorio)
		{
			_usuarioRepositorio = usuariosRepositorio;
		}
		public IActionResult Index()
		{
			return View();
		}

	}
}
