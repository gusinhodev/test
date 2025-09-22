using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FullStackMVC.Data;
using FullStackMVC.Models;

namespace FullStackMVC.Controllers
{
    public class SubclientesController : Controller
    {
        private readonly AppDbContext _context;

        public SubclientesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Subclientes
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Subclientes.Include(s => s.Cliente);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Subclientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subcliente = await _context.Subclientes
                .Include(s => s.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subcliente == null)
            {
                return NotFound();
            }

            return View(subcliente);
        }

        // GET: Subclientes/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nombre");
            return View();
        }

        // POST: Subclientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Email,Telefono,Empresa,ClienteId")] Subcliente subcliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subcliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nombre", subcliente.ClienteId);
            return View(subcliente);
        }

        // GET: Subclientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subcliente = await _context.Subclientes.FindAsync(id);
            if (subcliente == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nombre", subcliente.ClienteId);
            return View(subcliente);
        }

        // POST: Subclientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Email,Telefono,Empresa,ClienteId")] Subcliente subcliente)
        {
            if (id != subcliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subcliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubclienteExists(subcliente.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nombre", subcliente.ClienteId);
            return View(subcliente);
        }

        // GET: Subclientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subcliente = await _context.Subclientes
                .Include(s => s.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subcliente == null)
            {
                return NotFound();
            }

            return View(subcliente);
        }

        // POST: Subclientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subcliente = await _context.Subclientes.FindAsync(id);
            if (subcliente != null)
            {
                _context.Subclientes.Remove(subcliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubclienteExists(int id)
        {
            return _context.Subclientes.Any(e => e.Id == id);
        }
    }
}
