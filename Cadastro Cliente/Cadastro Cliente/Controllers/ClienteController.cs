using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Cliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult criar()
        {
            return View();
        }
        public IActionResult atualizar()
        {
            return View();
        }
        public IActionResult apagar()
        {
            return View();
        }
    }
}
