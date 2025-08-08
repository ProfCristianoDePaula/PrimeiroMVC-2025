using Microsoft.AspNetCore.Mvc;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Matricula()
        {
            return View();
        }
    }
}
