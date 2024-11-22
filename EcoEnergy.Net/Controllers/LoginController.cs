using EcoEnergy.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcoEnergy.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuario;
        public LoginController(IUsuarioRepository usuario)
        {
            _usuario = usuario;
        }
        public async Task<IActionResult> Index()
        { 
            return View();
        }

    }
}
