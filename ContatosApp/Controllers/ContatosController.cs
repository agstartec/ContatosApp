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
		public IActionResult EditarContato(int id)
		{
			ContatoModel contato =  _contatoRepositorio.ListarContato(id);
			return View(contato);
		}
		public IActionResult ApagarContatoConfirmar(int id)
		{
			ContatoModel contato = _contatoRepositorio.ListarContato(id);
			return View(contato);
		}
		public IActionResult ApagarContato(int id)
		{
			_contatoRepositorio.Apagar(id);
			return RedirectToAction("Index");
		}
		[HttpPost]
		public IActionResult CriarContato(ContatoModel contato) {
			_contatoRepositorio.Adicionar(contato);
			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult EditarContato(ContatoModel contato)
		{
			_contatoRepositorio.Editar(contato);
			return RedirectToAction("Index");
		}
	}
}
