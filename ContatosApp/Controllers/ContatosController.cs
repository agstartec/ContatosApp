using ContatosApp.Models;
using ContatosApp.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ContatosApp.Controllers
{
    public class ContatosController : Controller
    {
		private readonly IContatoRepositorio _contatoRepositorio;
        public ContatosController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
			List<ContatoModel> contatos = _contatoRepositorio.ListarTodos();
            return View(contatos);
        }
		public IActionResult CriarContato()
		{
			return View();
		}
		public IActionResult EditarContato()
		{
			return View();
		}
		public IActionResult ApagarContatoConfirmar()
		{
			return View();
		}public IActionResult ApagarContato()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CriarContato(ContatoModel contato) {
			_contatoRepositorio.Adicionar(contato);
			return RedirectToAction("Index");
		}
	}
}
