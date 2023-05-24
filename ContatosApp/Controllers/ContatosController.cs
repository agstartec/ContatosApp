using Microsoft.AspNetCore.Mvc;

namespace ContatosApp.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult CriarContato()
		{
			return View();
		}
	}
}
