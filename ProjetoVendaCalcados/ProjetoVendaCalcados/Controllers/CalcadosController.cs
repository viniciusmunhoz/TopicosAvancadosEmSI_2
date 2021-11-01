using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoVendaCalcados.Data;
using ProjetoVendaCalcados.Models;

namespace ProjetoVendaCalcados.Controllers
{
    [Authorize]
    public class CalcadosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CalcadosController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
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
        public async Task<IActionResult> Create([Bind("Id,NomeCalcado,Tipo,Numero,Preco,ImagemCalcado")] Calcado calcado)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(calcado.ImagemCalcado.FileName);
                string extension = Path.GetExtension(calcado.ImagemCalcado.FileName);

                calcado.Imagem = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/image", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await calcado.ImagemCalcado.CopyToAsync(fileStream);
                }

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
