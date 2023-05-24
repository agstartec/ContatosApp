using ContatosApp.Models;
using ContatosApp.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ContatosApp.Controllers
{
	public class LoginController : Controller
	{
		private readonly IUsuariosRepositorio _usuarioRepositorio;
        public LoginController(IUsuariosRepositorio usuariosRepositorio)
        {
            _usuarioRepositorio = usuariosRepositorio;
        }
        public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Entrar(LoginModel login) {
			try
			{
                if (ModelState.IsValid)
                {
					UsuarioModel usuario = _usuarioRepositorio.Autenticar(login.usuario);
					if (usuario != null)
					{
                        if (usuario.ValidarSenha(login.senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            return View("Index");
                        }

                    }
                    else
                    {
                        return View("Index");
                    }
                }
                else
                {
                    return View("Index");
                }
            }
			catch (Exception err)
			{

				return View("Index");
			}
		
		}
	}
}
