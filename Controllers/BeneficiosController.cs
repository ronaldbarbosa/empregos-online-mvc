using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmpregosOnLine.Data;
using EmpregosOnLine.Models;

namespace EmpregosOnLine.Controllers
{
    public class BeneficiosController : Controller
    {
        private readonly EmpregosOnLineDbContext _context;

        public BeneficiosController(EmpregosOnLineDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return _context.Beneficios != null ? 
                          View(await _context.Beneficios.ToListAsync()) :
                          Problem("Entity set 'EmpregosOnLineDbContext.Beneficios'  is null.");
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Beneficios == null)
            {
                return NotFound();
            }

            var beneficio = await _context.Beneficios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (beneficio == null)
            {
                return NotFound();
            }

            return View(beneficio);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo")] Beneficio beneficio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beneficio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(beneficio);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFromView(string beneficio)
        {
            if (beneficio != null && beneficio != "")
            {
                _context.Beneficios.Add(new Beneficio { Titulo = beneficio });
                await _context.SaveChangesAsync();
                return Json(new { mensagem = "Benefício adicionado com sucesso!" });
            }

            return Json(new { mensagem = "Dado inválido!" });
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Beneficios == null)
            {
                return NotFound();
            }

            var beneficio = await _context.Beneficios.FindAsync(id);
            if (beneficio == null)
            {
                return NotFound();
            }
            return View(beneficio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Titulo")] Beneficio beneficio)
        {
            if (id != beneficio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(beneficio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BeneficioExists(beneficio.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(beneficio);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Beneficios == null)
            {
                return NotFound();
            }

            var beneficio = await _context.Beneficios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (beneficio == null)
            {
                return NotFound();
            }

            return View(beneficio);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Beneficios == null)
            {
                return Problem("Entity set 'EmpregosOnLineDbContext.Beneficios'  is null.");
            }
            var beneficio = await _context.Beneficios.FindAsync(id);
            if (beneficio != null)
            {
                _context.Beneficios.Remove(beneficio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BeneficioExists(Guid id)
        {
          return (_context.Beneficios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
