using EcoEnergy.Repositories.Interfaces;
using EcoEnergy.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EcoEnergy.Controllers
{
    public class ProceduresController : Controller
    {
        private readonly IProceduresRepository _proceduresRepository;
        private readonly IEmpresaRepository _empresaRepository;

        public ProceduresController(IProceduresRepository proceduresRepository, IEmpresaRepository empresaRepository)
        {
            _proceduresRepository = proceduresRepository;
            _empresaRepository = empresaRepository;
        }

        public IActionResult MenuProcedures()
        {
            TempData["SuccessMessage"] = null;
            TempData["ErrorMessage"] = null;
            return View();
        }

        [HttpGet]
        public IActionResult EmpresaView()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListarEmpresas()
        {
            try
            {
                var empresas = await _empresaRepository.GetAll();
                return View(empresas);
            }
            catch (System.Exception e)
            {
                TempData["ErrorMessage"] = "Erro ao listar empresas!\n" + e.Message;
                return RedirectToAction("MenuProcedures");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EmpresaView(ProceduresViewModel model)
        {
            try
            {
                await _proceduresRepository.InsertEmpresa(
                    model.NrCnpj,
                    model.NmEmpresa,
                    model.NrTelefone,
                    model.DsEspecialidade
                );
                TempData["SuccessMessage"] = "Empresa inserida com sucesso!";
                return RedirectToAction("MenuProcedures");
            }
            catch (System.Exception e)
            {
                TempData["ErrorMessage"] = "Erro ao inserir empresa!\n" + e.Message;
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult UsuarioView()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UsuarioView(ProceduresViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _proceduresRepository.InsertUsuario(
                    model.NmUsuario,
                    model.DsEmail,
                    model.NrTelefone,
                    model.NrCpf,
                    model.IdEmpresa
                );
                TempData["SuccessMessage"] = "Usuário inserido com sucesso!";
                return RedirectToAction("MenuProcedures");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EnderecoView()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EnderecoView(ProceduresViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _proceduresRepository.InsertEndereco(
                    model.DsCep,
                    model.DsLogradouro,
                    model.NrLogradouro,
                    model.DsBairro,
                    model.DsCidade,
                    model.DsEstado,
                    model.DsPais,
                    model.IdUsuario,
                    model.IdEmpresa
                );
                TempData["SuccessMessage"] = "Endereço inserido com sucesso!";
                return RedirectToAction("MenuProcedures");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult OrcamentoView()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OrcamentoView(ProceduresViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _proceduresRepository.InsertOrcamento(
                    model.NrValorProposto,
                    model.DsPrazo,
                    model.DtOrcamento.ToDateTime(TimeOnly.MinValue),
                    model.DsServicos,
                    model.IdSimulacao,
                    model.IdEmpresa
                );
                TempData["SuccessMessage"] = "Orçamento inserido com sucesso!";
                return RedirectToAction("MenuProcedures");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult SimulacaoView()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SimulacaoView(ProceduresViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _proceduresRepository.InsertSimulacao(
                    model.NrCustoEstimado,
                    model.NrEconomia,
                    model.DtSimulacao.ToDateTime(TimeOnly.MinValue),
                    model.NrConsumoMensal,
                    model.NrAreaPlaca,
                    model.NrPotenciaEstimada,
                    model.NrProducaoMensal,
                    model.NrTempoRetornoInvestimento,
                    model.DsOrcamentoSolicitado,
                    model.IdUsuario,
                    model.IdEndereco
                );
                TempData["SuccessMessage"] = "Simulação inserida com sucesso!";
                return RedirectToAction("MenuProcedures");
            }
            return View(model);
        }
    }
}
