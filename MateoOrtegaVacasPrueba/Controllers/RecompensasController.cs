using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MateoOrtegaVacasPrueba.Models;

namespace MateoOrtegaVacasPrueba.Controllers
{
    public class RecompensasController : Controller
    {
        private readonly MateoBDC _context;

        public RecompensasController(MateoBDC context)
        {
            _context = context;
        }

        // GET: Recompensas
        public async Task<IActionResult> Index()
        {
            var mateoBDC = _context.Recompensa.Include(r => r.Cliente);
            return View(await mateoBDC.ToListAsync());
        }

        // GET: Recompensas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recompensa = await _context.Recompensa
                .Include(r => r.Cliente)
                .FirstOrDefaultAsync(m => m.IdRecompensa == id);
            if (recompensa == null)
            {
                return NotFound();
            }

            return View(recompensa);
        }

        // GET: Recompensas/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "IdCliente", "NombreCliente");
            return View();
        }

        // POST: Recompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRecompensa,Nombre,FechaInicio,Puntos,TipoRecompensa,ClienteId")] Recompensa recompensa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recompensa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "IdCliente", "NombreCliente", recompensa.ClienteId);
            return View(recompensa);
        }

        // GET: Recompensas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recompensa = await _context.Recompensa.FindAsync(id);
            if (recompensa == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "IdCliente", "NombreCliente", recompensa.ClienteId);
            return View(recompensa);
        }

        // POST: Recompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRecompensa,Nombre,FechaInicio,Puntos,TipoRecompensa,ClienteId")] Recompensa recompensa)
        {
            if (id != recompensa.IdRecompensa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recompensa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecompensaExists(recompensa.IdRecompensa))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "IdCliente", "NombreCliente", recompensa.ClienteId);
            return View(recompensa);
        }

        // GET: Recompensas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recompensa = await _context.Recompensa
                .Include(r => r.Cliente)
                .FirstOrDefaultAsync(m => m.IdRecompensa == id);
            if (recompensa == null)
            {
                return NotFound();
            }

            return View(recompensa);
        }

        // POST: Recompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recompensa = await _context.Recompensa.FindAsync(id);
            if (recompensa != null)
            {
                _context.Recompensa.Remove(recompensa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecompensaExists(int id)
        {
            return _context.Recompensa.Any(e => e.IdRecompensa == id);
        }
    }
}
