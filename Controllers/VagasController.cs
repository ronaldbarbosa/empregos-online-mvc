using EmpregosOnLine.Data;
using EmpregosOnLine.Models;
using EmpregosOnLine.Models.ViewModels;
using EmpregosOnLine.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

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

        public async Task<ActionResult> Index()
        {
            var vagas = await _vagasService.GetVagasAsync();
            return View(vagas);
        }

        public async Task<ActionResult> Details(Guid id)
        {
            var vaga = await _vagasService.GetVagaAsync(id);
            if (vaga == null)
            {
                return NotFound();
            }
            return View(vaga);
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
                TipoPerfil = vagaForm.TiposPerfil.First(),
                Empresa = await _dbContext.Empresas.FindAsync(vagaForm.EmpresaId),
                EmpresaId = vagaForm.EmpresaId,
                Salario = vagaForm.Salario,
                ACombinarSalario = vagaForm.ACombinarSalario
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

        public async Task<ActionResult> Edit(Guid id)
        {
            var vaga =  await _vagasService.GetVagaAsync(id);

            if (vaga == null)
            {
                return NotFound();
            }

            var formView = new VagaFormViewModel()
            {
                Id = vaga.Id,
                Habilidades = await _dbContext.Habilidades.ToListAsync(),
                Beneficios = await _dbContext.Beneficios.ToListAsync(),
                Empresas = await _dbContext.Empresas.ToListAsync()
            };

            foreach (var habilidade in vaga.Habilidades)
            {
                formView.HabilidadesSelecionadas.Add(habilidade);
            }
            foreach (var beneficios in vaga.Beneficios)
            {
                formView.BeneficiosSelecionados.Add(beneficios);
            }

            formView.EmpresaId = vaga.EmpresaId;
            formView.NomeEmpresa = vaga.Empresa.Nome;
            formView.Titulo = vaga.Titulo;
            formView.Descricao = vaga.Descricao;
            
            return View(formView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Guid Id, VagaFormViewModel vagaForm)
        {
            var vaga = await _vagasService.GetVagaAsync(Id);

            vaga.Titulo = vagaForm.Titulo;
            vaga.Descricao = vagaForm.Descricao;
            vaga.TipoVaga = vagaForm.TiposVaga.First();
            vaga.TipoContrato = vagaForm.TiposContrato.First();
            vaga.TipoPerfil = vagaForm.TiposPerfil.First();
            vaga.Empresa = await _dbContext.Empresas.FindAsync(vagaForm.EmpresaId);
            vaga.EmpresaId = vagaForm.EmpresaId;
            vaga.Ativa = vagaForm.Ativa;

            vaga.Beneficios = new Collection<Beneficio>();
            vaga.Habilidades = new Collection<Habilidade>();

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

            await _vagasService.UpdateVagaAsync(vaga);

            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            var vaga = await _vagasService.GetVagaAsync(id);
            if (vaga == null)
            {
                return NotFound();
            }
            return View(vaga);
        }

        // POST: VagasController/Delete/5
        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            await _vagasService.RemoveVagaAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
