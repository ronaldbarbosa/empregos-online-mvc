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

        // GET: EmpresasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpresasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpresasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpresasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
