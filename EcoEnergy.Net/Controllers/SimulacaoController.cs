using Microsoft.AspNetCore.Mvc;
using WebApplicationOdontoPrev.ViewModels;

namespace WebApplicationOdontoPrev.Controllers
{
    public class SimulacaoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new SimulacaoViewModel());
        }

        [HttpPost]
        public IActionResult Index(SimulacaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                double precoPorPlaca = 1500;
                double eficienciaPlaca = 350;
                double horasSolPlena = 5;

                double consumoDiario = model.NrConsumoMensal / 30;
                double potenciaNecessaria = consumoDiario / horasSolPlena;

                double placasNecessarias = Math.Ceiling(potenciaNecessaria / eficienciaPlaca);

                double areaPorPlaca = 2;
                double totalAreaNecessaria = placasNecessarias * areaPorPlaca;

                if (model.NrAreaPlaca >= totalAreaNecessaria)
                {
                    model.NrCustoEstimado = placasNecessarias * precoPorPlaca;
                }
                else
                {
                    model.NrCustoEstimado = 0;
                    ModelState.AddModelError("", "A área disponível não é suficiente para instalar as placas necessárias.");
                }

                return View(model);
            }

            return View(model);
        }
    }
}
