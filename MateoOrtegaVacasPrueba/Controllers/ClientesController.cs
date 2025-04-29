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
    public class ClientesController : Controller
    {
        private readonly MateoBDC _context;

        public ClientesController(MateoBDC context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var mateoBDC = _context.Cliente.Include(c => c.Recompensa).Include(c => c.Reserva);
            return View(await mateoBDC.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.Recompensa)
                .Include(c => c.Reserva)
                .FirstOrDefaultAsync(m => m.idCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewData["idRecompensa"] = new SelectList(_context.Set<Recompensa>(), "idRecompensa", "idRecompensa");
            ViewData["idReserva"] = new SelectList(_context.Set<Reserva>(), "idReserva", "idReserva");
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idCliente,nombreCliente,fechaRegistro,reservaVigente,totalGastos,mateoOrtegaVacas,idRecompensa,idReserva")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idRecompensa"] = new SelectList(_context.Set<Recompensa>(), "idRecompensa", "idRecompensa", cliente.idRecompensa);
            ViewData["idReserva"] = new SelectList(_context.Set<Reserva>(), "idReserva", "idReserva", cliente.idReserva);
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["idRecompensa"] = new SelectList(_context.Set<Recompensa>(), "idRecompensa", "idRecompensa", cliente.idRecompensa);
            ViewData["idReserva"] = new SelectList(_context.Set<Reserva>(), "idReserva", "idReserva", cliente.idReserva);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCliente,nombreCliente,fechaRegistro,reservaVigente,totalGastos,mateoOrtegaVacas,idRecompensa,idReserva")] Cliente cliente)
        {
            if (id != cliente.idCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.idCliente))
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
            ViewData["idRecompensa"] = new SelectList(_context.Set<Recompensa>(), "idRecompensa", "idRecompensa", cliente.idRecompensa);
            ViewData["idReserva"] = new SelectList(_context.Set<Reserva>(), "idReserva", "idReserva", cliente.idReserva);
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.Recompensa)
                .Include(c => c.Reserva)
                .FirstOrDefaultAsync(m => m.idCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente != null)
            {
                _context.Cliente.Remove(cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.idCliente == id);
        }
    }
}
