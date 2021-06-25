using DAL;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPP01.Controllers
{
    public class HomeController : Controller
    {
        private IFuncionarios _funcionarios;

        public HomeController(IFuncionarios funcionarios)
        {
            _funcionarios = funcionarios;
        }

        public IActionResult Index()
        {
            var func = _funcionarios.GetFuncionarios();
            return View(func);
        }

        public IActionResult Sobre()
        {
            return View();
        }
    }
}
