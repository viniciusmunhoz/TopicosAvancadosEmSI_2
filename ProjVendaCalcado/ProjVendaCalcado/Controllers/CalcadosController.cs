using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjVendaCalcado.Data;
using ProjVendaCalcado.Models;

namespace ProjVendaCalcado.Controllers
{
    public class CalcadosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalcadosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Calcados
        public async Task<IActionResult> Index()
        {
            return View(await _context.Calcado.ToListAsync());
        }

        // GET: Calcados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calcado = await _context.Calcado.FirstOrDefaultAsync(m => m.Id == id);
            if (calcado == null)
            {
                return NotFound();
            }

            return View(calcado);
        }

        // GET: Calcados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Calcados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeCalcado,Tipo,Numero,Preco,Imagem")] Calcado calcado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calcado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calcado);
        }

        // GET: Calcados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calcado = await _context.Calcado.FindAsync(id);
            if (calcado == null)
            {
                return NotFound();
            }
            return View(calcado);
        }

        // POST: Calcados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeCalcado,Tipo,Numero,Preco,Imagem")] Calcado calcado)
        {
            if (id != calcado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calcado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalcadoExists(calcado.Id))
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
            return View(calcado);
        }

        // GET: Calcados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calcado = await _context.Calcado
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calcado == null)
            {
                return NotFound();
            }

            return View(calcado);
        }

        // POST: Calcados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calcado = await _context.Calcado.FindAsync(id);
            _context.Calcado.Remove(calcado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalcadoExists(int id)
        {
            return _context.Calcado.Any(e => e.Id == id);
        }
    }
}
