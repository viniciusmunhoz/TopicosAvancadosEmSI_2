using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjAPIBoletim.Data;
using ProjAPIBoletim.Models;

namespace ProjAPIBoletim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoletimsController : ControllerBase
    {
        private readonly ProjAPIBoletimContext _context;

        public BoletimsController(ProjAPIBoletimContext context)
        {
            _context = context;
        }

        // GET: api/Boletims
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Boletim>>> GetBoletim()
        {
            return await _context.Boletim.ToListAsync();
        }

        // GET: api/Boletims/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Boletim>> GetBoletim(int id)
        {
            var boletim = await _context.Boletim.FindAsync(id);

            if (boletim == null)
            {
                return NotFound();
            }

            return boletim;
        }

        // PUT: api/Boletims/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoletim(int id, Boletim boletim)
        {
            if (id != boletim.Id)
            {
                return BadRequest();
            }

            _context.Entry(boletim).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoletimExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Boletims
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Boletim>> PostBoletim(Boletim boletim)
        {
            _context.Boletim.Add(boletim);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoletim", new { id = boletim.Id }, boletim);
        }

        // DELETE: api/Boletims/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoletim(int id)
        {
            var boletim = await _context.Boletim.FindAsync(id);
            if (boletim == null)
            {
                return NotFound();
            }

            _context.Boletim.Remove(boletim);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BoletimExists(int id)
        {
            return _context.Boletim.Any(e => e.Id == id);
        }
    }
}
