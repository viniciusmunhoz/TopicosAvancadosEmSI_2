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
    public class CursosController : Controller
    {
        private readonly ProjMvcBoletimContext _context;

        public CursosController(ProjMvcBoletimContext context)
        {
            _context = context;
        }

        // GET: Cursos
        public async Task<IActionResult> Index()
        {
            var Aluno = await _context.Curso.Include(c => c.Aluno).Include(d => d.Disciplina).ToListAsync();
            //return View(await _context.Curso.ToListAsync());
            return View(Aluno);
        }

        // GET: Cursos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Curso
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // GET: Cursos/Create
        public IActionResult Create()
        {
            var c = new Curso();
            var alunos = _context.Aluno.ToList();
            var disciplinas = _context.Disciplina.ToList();

            c.Alunos = new List<SelectListItem>();
            c.Disciplinas = new List<SelectListItem>();

            foreach (var alu in alunos)
            {
                c.Alunos.Add(new SelectListItem { Text = alu.Nome, Value = alu.Id.ToString() });
            }

            foreach (var dis in disciplinas)
            {
                c.Disciplinas.Add(new SelectListItem { Text = dis.NomeDisciplina, Value = dis.Id.ToString() });
            }

            return View(c);
        }

        // POST: Cursos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeCurso,DataCadastro")] Curso curso)
        {
            int _alunoId = int.Parse(Request.Form["Aluno"].ToString());
            var aluno = _context.Aluno.FirstOrDefault(a => a.Id == _alunoId);
            curso.Aluno = aluno;

            int _disciplinaId = int.Parse(Request.Form["Disciplina"].ToString());
            var disciplina = _context.Disciplina.FirstOrDefault(d => d.Id == _disciplinaId);
            curso.Disciplina = disciplina;

            if (ModelState.IsValid)
            {
                _context.Add(curso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(curso);
        }

        // GET: Cursos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Curso.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }

            var disciplinas = _context.Disciplina.ToList();
            curso.Disciplinas = new List<SelectListItem>();
            foreach (var dis in disciplinas)
            {
                curso.Disciplinas.Add(new SelectListItem { Text = dis.NomeDisciplina, Value = dis.Id.ToString() });
            }

            var alunos = _context.Aluno.ToList();
            curso.Alunos = new List<SelectListItem>();
            foreach (var aluno in alunos)
            {
                curso.Alunos.Add(new SelectListItem { Text = aluno.Nome, Value = aluno.Id.ToString() });
            }

            return View(curso);
        }

        // POST: Cursos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeCurso,DataCadastro")] Curso curso)
        {
            if (id != curso.Id)
            {
                return NotFound();
            }
            /////////////////////////////////////////////
            int _alunoId = int.Parse(Request.Form["Aluno"].ToString());
            var aluno = _context.Aluno.FirstOrDefault(a => a.Id == _alunoId);
            curso.Aluno = aluno;

            int _disciplinaId = int.Parse(Request.Form["Disciplina"].ToString());
            var disciplina = _context.Disciplina.FirstOrDefault(d => d.Id == _disciplinaId);
            curso.Disciplina = disciplina;
            ///////////////////////////////////////////

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursoExists(curso.Id))
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
            return View(curso);
        }

        // GET: Cursos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Curso
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curso = await _context.Curso.FindAsync(id);
            _context.Curso.Remove(curso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CursoExists(int id)
        {
            return _context.Curso.Any(e => e.Id == id);
        }
    }
}
