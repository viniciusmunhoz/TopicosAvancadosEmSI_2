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
    public class BoletimController : Controller
    {
        private readonly ProjMvcBoletimContext _context;

        public BoletimController(ProjMvcBoletimContext context)
        {
            _context = context;
        }

        // GET: Boletim
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Boletim.ToListAsync());
            var Aluno = await _context.Boletim.Include(c => c.Aluno).ToListAsync();
            var Disc = await _context.Boletim.Include(c => c.Disciplina).ToListAsync();

            return View(Aluno);
        }

        // GET: Boletim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boletim = await _context.Boletim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boletim == null)
            {
                return NotFound();
            }

            return View(boletim);
        }

        // GET: Boletim/Create
        public IActionResult Create()
        {
            var B = new Boletim();

            var alunos = _context.Aluno.ToList();

            B.Alunos = new List<SelectListItem>();
            foreach (var aluno in alunos)
            {
                B.Alunos.Add(new SelectListItem { Text = aluno.Nome, Value = aluno.Id.ToString() });
            }
            //////

            //ADD DISCIPLINA AO BOLETIM
            var disciplinas = _context.Disciplina.ToList();
            B.Disciplinas = new List<SelectListItem>();
            foreach (var dis in disciplinas)
            {
                B.Disciplinas.Add(new SelectListItem { Text = dis.NomeDisciplina, Value = dis.Id.ToString() });
            }
            //////


            return View(B);
        }

        // POST: Boletim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Soma,Media,Situacao")] Boletim boletim)
        {
            //
            boletim.Bimestre1 = float.Parse(Request.Form["Bimestre1"].ToString());
            boletim.Bimestre2 = float.Parse(Request.Form["Bimestre2"].ToString());
            boletim.Bimestre3 = float.Parse(Request.Form["Bimestre3"].ToString());
            boletim.Bimestre4 = float.Parse(Request.Form["Bimestre4"].ToString());

            //ADD ALUNO
            int _alunoId = int.Parse(Request.Form["Aluno"].ToString());
            var aluno = _context.Aluno.FirstOrDefault(d => d.Id == _alunoId);
            boletim.Aluno = aluno;
            //

            //ADD DISCIPLINA
            int _disciplinaId = int.Parse(Request.Form["Disciplina"].ToString());
            var disciplina = _context.Disciplina.FirstOrDefault(d => d.Id == _disciplinaId);
            boletim.Disciplina = disciplina;
            //

            boletim.Soma = boletim.Bimestre1 + boletim.Bimestre2 + boletim.Bimestre3 + boletim.Bimestre4;

            if(boletim.Soma > 0)
            {
                boletim.Media = float.Parse(boletim.Soma.ToString()) / 4;
            }

            if(boletim.Media >= 5)
            {
                boletim.Situacao = "APROVADO";
            }
            else
            {
                boletim.Situacao = "REPROVADO";
            }

            if (ModelState.IsValid)
            {
                _context.Add(boletim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boletim);
        }

        // GET: Boletim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var boletim = await _context.Boletim.FindAsync(id);
            if (boletim == null)
            {
                return NotFound();
            }


            var alunos = _context.Aluno.ToList();
            boletim.Alunos = new List<SelectListItem>();
            foreach (var aluno in alunos)
            {
                boletim.Alunos.Add(new SelectListItem { Text = aluno.Nome, Value = aluno.Id.ToString() });
            }

            var disciplinas = _context.Disciplina.ToList();
            boletim.Disciplinas = new List<SelectListItem>();
            foreach (var dis in disciplinas)
            {
                boletim.Disciplinas.Add(new SelectListItem { Text = dis.NomeDisciplina, Value = dis.Id.ToString() });
            }

            boletim.Soma = boletim.Bimestre1 + boletim.Bimestre2 + boletim.Bimestre3 + boletim.Bimestre4;

            if (boletim.Soma > 0)
            {
                boletim.Media = float.Parse(boletim.Soma.ToString()) / 4;
            }

            if (boletim.Media >= 5)
            {
                boletim.Situacao = "APROVADO";
            }
            else
            {
                boletim.Situacao = "REPROVADO";
            }

            return View(boletim);
        }

        // POST: Boletim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Soma,Media,Situacao")] Boletim boletim)
        {
            if (id != boletim.Id)
            {
                return NotFound();
            }


            int _AlunoId = int.Parse(Request.Form["Aluno"].ToString());
            var aluno = _context.Aluno.FirstOrDefault(d => d.Id == _AlunoId);
            boletim.Aluno = aluno;

            int _disciplinaId = int.Parse(Request.Form["Disciplina"].ToString());
            var disciplina = _context.Disciplina.FirstOrDefault(d => d.Id == _disciplinaId);
            boletim.Disciplina = disciplina;

            boletim.Soma = boletim.Bimestre1 + boletim.Bimestre2 + boletim.Bimestre3 + boletim.Bimestre4;

            if (boletim.Soma > 0)
            {
                boletim.Media = float.Parse(boletim.Soma.ToString()) / 4;
            }

            if (boletim.Media >= 5)
            {
                boletim.Situacao = "APROVADO";
            }
            else
            {
                boletim.Situacao = "REPROVADO";
            }


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boletim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoletimExists(boletim.Id))
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
            return View(boletim);
        }

        // GET: Boletim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boletim = await _context.Boletim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boletim == null)
            {
                return NotFound();
            }

            return View(boletim);
        }

        // POST: Boletim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boletim = await _context.Boletim.FindAsync(id);
            _context.Boletim.Remove(boletim);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoletimExists(int id)
        {
            return _context.Boletim.Any(e => e.Id == id);
        }
    }
}
