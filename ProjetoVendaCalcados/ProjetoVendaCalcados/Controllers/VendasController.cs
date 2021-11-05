using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoVendaCalcados.Data;
using ProjetoVendaCalcados.Models;

namespace ProjetoVendaCalcados.Controllers
{
    [Authorize]
    public class VendasController : Controller
    {    
        private readonly ApplicationDbContext _context;

        public VendasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Venda.Include(c => c.Cliente).Include(v => v.Vendedor).Include(l => l.Loja).ToListAsync());
        }

        // GET: Vendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var venda = await _context.Venda.FirstOrDefaultAsync(m => m.Id == id);
            var venda = _context.Venda.Include(c => c.Cliente).First(i => i.Id == id);

            //Preenchendo a lista de clientes
            var clientes = _context.Cliente.ToList();
            venda.Clientes = new List<SelectListItem>();
            foreach (var ItemCliente in clientes)
            {
                venda.Clientes.Add(new SelectListItem { Text = ItemCliente.Nome, Value = ItemCliente.Id.ToString() });
            }
            //

            //Preenchendo a lista de Vendedores
            var vendedores = _context.Vendedor.ToList();
            venda.Vendedores = new List<SelectListItem>();
            foreach (var ItemVendedores in vendedores)
            {
                venda.Vendedores.Add(new SelectListItem { Text = ItemVendedores.NomeVendedor, Value = ItemVendedores.Id.ToString() });
            }
            //

            //Preenchendo a lista de Lojas
            var lojas = _context.Loja.ToList();
            venda.Lojas = new List<SelectListItem>();
            foreach (var ItemLojas in lojas)
            {
                venda.Lojas.Add(new SelectListItem { Text = ItemLojas.Id.ToString(), Value = ItemLojas.Id.ToString() });
            }
            //


            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // GET: Vendas/Create
        public IActionResult Create()
        {
            var v = new Venda();
            var clientes = _context.Cliente.ToList();
            var calcados = _context.Calcado.ToList();
            var vendedores = _context.Vendedor.ToList();
            var lojas = _context.Loja.ToList();

            v.Clientes = new List<SelectListItem>();
            v.Calcados = new List<SelectListItem>();
            v.Vendedores = new List<SelectListItem>();
            v.Lojas = new List<SelectListItem>();

            foreach (var cli in clientes)
            {
                v.Clientes.Add(new SelectListItem { Text = cli.Nome, Value = cli.Id.ToString() });
            }

            foreach (var cal in calcados)
            {
                v.Calcados.Add(new SelectListItem { Text = cal.NomeCalcado, Value = cal.Id.ToString() });
            }

            foreach (var vende in vendedores)
            {
                v.Vendedores.Add(new SelectListItem { Text = vende.NomeVendedor.ToString(), Value = vende.Id.ToString() });
            }

            foreach (var loj in lojas)
            {
                v.Lojas.Add(new SelectListItem { Text = loj.Id.ToString(), Value = loj.Id.ToString() });
            }


            return View(v);
        }

        // POST: Vendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeVendedor,Descricao,DataVenda")] Venda venda)
        {
            if (ModelState.IsValid)
            {
                int _clienteId = int.Parse(Request.Form["Cliente"].ToString());
                var cliente = _context.Cliente.FirstOrDefault(c => c.Id == _clienteId);
                venda.Cliente = cliente;

                string _itensID = Request.Form["Calcado"].ToString();

                string[] subs = _itensID.Split(',');

                foreach (string sub in subs)
                {
                    var calcados = _context.Calcado.FirstOrDefault(c => c.Id == int.Parse(sub));
                    venda.Total += calcados.Preco;
                }
     
                venda.Itens = _itensID;

                int _vendedorId = int.Parse(Request.Form["Vendedor"].ToString());
                var vendedor = _context.Vendedor.FirstOrDefault(c => c.Id == _vendedorId);
                venda.Vendedor = vendedor;

                int _lojaId = int.Parse(Request.Form["Loja"].ToString());
                var loja = _context.Loja.FirstOrDefault(c => c.Id == _lojaId);
                venda.Loja = loja;
 

                _context.Add(venda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venda);
        }

        // GET: Vendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Venda.FindAsync(id);
            if (venda == null)
            {
                return NotFound();
            }
            return View(venda);
        }

        // POST: Vendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao,DataVenda")] Venda venda)
        {
            if (id != venda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaExists(venda.Id))
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
            return View(venda);
        }

        // GET: Vendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Venda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venda = await _context.Venda.FindAsync(id);
            _context.Venda.Remove(venda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaExists(int id)
        {
            return _context.Venda.Any(e => e.Id == id);
        }
    }
}
