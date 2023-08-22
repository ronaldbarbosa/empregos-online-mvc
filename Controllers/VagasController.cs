using EmpregosOnLine.Data;
using EmpregosOnLine.Models;
using EmpregosOnLine.Models.Enums;
using EmpregosOnLine.Models.ViewModels;
using EmpregosOnLine.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmpregosOnLine.Controllers
{
    public class VagasController : Controller
    {
        private readonly VagasService _vagasService;
        private readonly EmpregosOnLineDbContext _dbContext;

        public VagasController(VagasService vagasService, EmpregosOnLineDbContext dbContext)
        {
            _vagasService = vagasService;
            _dbContext = dbContext;
        }
        // GET: VagasController
        public async Task<ActionResult> Index()
        {
            var vagas = await _vagasService.GetVagasAsync();
            return View(vagas);
        }

        // GET: VagasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public async Task<ActionResult> Create()
        {
            var formView = new VagaFormViewModel()
            {
                Habilidades = await _dbContext.Habilidades.ToListAsync(),
                Beneficios = await _dbContext.Beneficios.ToListAsync(),
                Empresas = await _dbContext.Empresas.ToListAsync()
            };

            return View(formView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(VagaFormViewModel vagaForm)
        {
            var vaga = new Vaga
            {
                Id = Guid.NewGuid(),
                Titulo = vagaForm.Titulo,
                Descricao = vagaForm.Descricao,
                TipoVaga = vagaForm.TiposVaga.First(),
                TipoContrato = vagaForm.TiposContrato.First(),
                Empresa = await _dbContext.Empresas.FindAsync(vagaForm.EmpresaId),
                EmpresaId = vagaForm.EmpresaId,
            };

            var beneficios = HttpContext.Request.Form["BeneficiosSelecionados"];
            foreach (var beneficioId in beneficios)
            {
                var beneficio = _dbContext.Beneficios.FirstOrDefault(b => b.Id == new Guid(beneficioId));
                vaga.Beneficios.Add(beneficio);
            }

            var habilidades = HttpContext.Request.Form["HabilidadesSelecionadas"];
            foreach (var habilidadeId in habilidades)
            {
                var habilidade = _dbContext.Habilidades.FirstOrDefault(h => h.Id == new Guid(habilidadeId));
                vaga.Habilidades.Add(habilidade);
            }

            await _vagasService.CreateVagaAsync(vaga);
            
            return RedirectToAction(nameof(Index));
        }

        // GET: VagasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VagasController/Edit/5
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

        // GET: VagasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VagasController/Delete/5
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
