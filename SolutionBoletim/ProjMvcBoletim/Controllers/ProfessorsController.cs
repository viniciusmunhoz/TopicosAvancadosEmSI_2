using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjMvcBoletim.Data;
using ProjMvcBoletim.Models;

namespace ProjMvcBoletim.Controllers
{
    public class ProfessorsController : Controller
    {
        private readonly ProjMvcBoletimContext _context;

        public ProfessorsController(ProjMvcBoletimContext context)
        {
            _context = context;
        }

        // GET: Professors
        public async Task<IActionResult> Index()
        {
           // return View(await _context.Professor.ToListAsync());
            //var Professor = await _context.Professor.Include(c => c.Nome).ToListAsync();
            var Disc = await _context.Professor.Include(c => c.Disciplina).ToListAsync();
            return View(Disc);
        }

        // GET: Professors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }

        // GET: Professors/Create
        public IActionResult Create()
        {
            var P = new Professor();
            var disciplinas = _context.Disciplina.ToList();

            P.Disciplinas = new List<SelectListItem>();

            foreach (var dis in disciplinas)
            {
                P.Disciplinas.Add(new SelectListItem { Text = dis.NomeDisciplina, Value = dis.Id.ToString() });
            }

            return View(P);
        }

        // POST: Professors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Telefone,DataNascimento,Endereco")] Professor professor)
        {

            int _disciplinaId = int.Parse(Request.Form["Disciplina"].ToString());
            var disciplina = _context.Disciplina.FirstOrDefault(d => d.Id == _disciplinaId);
            professor.Disciplina = disciplina;

            if (ModelState.IsValid)
            {
                _context.Add(professor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(professor);
        }

        // GET: Professors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor.FindAsync(id);
            if (professor == null)
            {
                return NotFound();
            }

            var disciplinas = _context.Disciplina.ToList();

            professor.Disciplinas = new List<SelectListItem>();
            foreach (var dis in disciplinas)
            {
                professor.Disciplinas.Add(new SelectListItem { Text = dis.NomeDisciplina, Value = dis.Id.ToString() });
            }


            return View(professor);
        }


        // POST: Professors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Telefone,DataNascimento,Endereco")] Professor professor)
        {
            if (id != professor.Id)
            {
                return NotFound();
            }

            int _disciplinaId = int.Parse(Request.Form["Disciplina"].ToString());
            var disciplina = _context.Disciplina.FirstOrDefault(d => d.Id == _disciplinaId);
            professor.Disciplina = disciplina;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(professor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessorExists(professor.Id))
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
            return View(professor);
        }

        // GET: Professors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }

        // POST: Professors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var professor = await _context.Professor.FindAsync(id);
            _context.Professor.Remove(professor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfessorExists(int id)
        {
            return _context.Professor.Any(e => e.Id == id);
        }
    }
}
