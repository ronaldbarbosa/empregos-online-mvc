using EmpregosOnLine.Models;
using EmpregosOnLine.Models.ViewModels;
using EmpregosOnLine.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpregosOnLine.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly EmpresasService _empresasService;

        public EmpresasController(EmpresasService empresasService)
        {
            _empresasService = empresasService;
        }

        public async Task<ActionResult> Index()
        {
            var empresas = await _empresasService.GetEmpresasAsync();
            return View(empresas);
        }

        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var empresa = await _empresasService.GetEmpresaAsync(id.Value);

            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmpresaEnderecoViewModel empresaEnderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                await _empresasService.CreateEmpresaAsync(empresaEnderecoViewModel.Empresa);

                return RedirectToAction(nameof(Index));
            }
            return View(empresaEnderecoViewModel);
        }

        // GET: EmpresasController/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            var empresa = await _empresasService.GetEmpresaAsync(id);
            
            if (empresa == null)
            {
                return NotFound();
            }
            
            var viewModel = new EmpresaEnderecoViewModel { Id = empresa.Id, Empresa = empresa, Endereco = empresa.Endereco };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EmpresaEnderecoViewModel empresaEnderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                await _empresasService.UpdateEmpresaAsync(empresaEnderecoViewModel.Empresa);
                return RedirectToAction(nameof(Index));
            }

            return View(empresaEnderecoViewModel);
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            var empresa = await _empresasService.GetEmpresaAsync(id);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);
        }

        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            var empresa = await _empresasService.GetEmpresaAsync(id);
            await _empresasService.DeleteEmpresaAsync(empresa);
            return RedirectToAction(nameof(Index));
        }
    }
}
