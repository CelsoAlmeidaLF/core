using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEBAPP01.Models;
using DAL;
using ENT;

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
