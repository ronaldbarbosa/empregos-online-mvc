using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmpregosOnLine.Data;
using EmpregosOnLine.Models;

namespace EmpregosOnLine.Controllers
{
    public class HabilidadesController : Controller
    {
        private readonly EmpregosOnLineDbContext _context;

        public HabilidadesController(EmpregosOnLineDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return _context.Habilidades != null ? 
                          View(await _context.Habilidades.ToListAsync()) :
                          Problem("Entity set 'EmpregosOnLineDbContext.Habilidades'  is null.");
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Habilidades == null)
            {
                return NotFound();
            }

            var habilidade = await _context.Habilidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habilidade == null)
            {
                return NotFound();
            }

            return View(habilidade);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo")] Habilidade habilidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(habilidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(habilidade);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Habilidades == null)
            {
                return NotFound();
            }

            var habilidade = await _context.Habilidades.FindAsync(id);
            if (habilidade == null)
            {
                return NotFound();
            }
            return View(habilidade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Titulo")] Habilidade habilidade)
        {
            if (id != habilidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(habilidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HabilidadeExists(habilidade.Id))
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
            return View(habilidade);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Habilidades == null)
            {
                return NotFound();
            }

            var habilidade = await _context.Habilidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habilidade == null)
            {
                return NotFound();
            }

            return View(habilidade);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Habilidades == null)
            {
                return Problem("Entity set 'EmpregosOnLineDbContext.Habilidades'  is null.");
            }
            var habilidade = await _context.Habilidades.FindAsync(id);
            if (habilidade != null)
            {
                _context.Habilidades.Remove(habilidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HabilidadeExists(Guid id)
        {
          return (_context.Habilidades?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
