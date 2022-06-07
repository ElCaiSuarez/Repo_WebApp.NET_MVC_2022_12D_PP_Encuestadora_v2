using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.NET_MVC_2022_12D_PP_Encuestadora.Context;
using WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Controllers
{
    public class EncuestaController : Controller
    {
        private readonly EncuestadoraDBContext _context;

        public EncuestaController(EncuestadoraDBContext context)
        {
            _context = context;
        }

        // GET: Encuesta
        public async Task<IActionResult> Index()
        {
            var encuestadoraDBContext = _context.encuestas.Include(e => e.Cliente);
            return View(await encuestadoraDBContext.ToListAsync());
        }

        // GET: Encuesta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuesta = await _context.encuestas
                .Include(e => e.Cliente)
                .FirstOrDefaultAsync(m => m.EncuestaId == id);
            if (encuesta == null)
            {
                return NotFound();
            }

            return View(encuesta);
        }

        // GET: Encuesta/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.clientes, "ClienteId", "mailCliente");
            return View();
        }

        // POST: Encuesta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EncuestaId,tituloEncuesta,datetimeCreacionEncuesta,datetimeVencimientoEncuesta,puntosEncuesta,ClienteId")] Encuesta encuesta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(encuesta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.clientes, "ClienteId", "mailCliente", encuesta.ClienteId);
            return View(encuesta);
        }

        // GET: Encuesta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuesta = await _context.encuestas.FindAsync(id);
            if (encuesta == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.clientes, "ClienteId", "mailCliente", encuesta.ClienteId);
            return View(encuesta);
        }

        // POST: Encuesta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EncuestaId,tituloEncuesta,datetimeCreacionEncuesta,datetimeVencimientoEncuesta,puntosEncuesta,ClienteId")] Encuesta encuesta)
        {
            if (id != encuesta.EncuestaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(encuesta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EncuestaExists(encuesta.EncuestaId))
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
            ViewData["ClienteId"] = new SelectList(_context.clientes, "ClienteId", "mailCliente", encuesta.ClienteId);
            return View(encuesta);
        }

        // GET: Encuesta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuesta = await _context.encuestas
                .Include(e => e.Cliente)
                .FirstOrDefaultAsync(m => m.EncuestaId == id);
            if (encuesta == null)
            {
                return NotFound();
            }

            return View(encuesta);
        }

        // POST: Encuesta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var encuesta = await _context.encuestas.FindAsync(id);
            _context.encuestas.Remove(encuesta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EncuestaExists(int id)
        {
            return _context.encuestas.Any(e => e.EncuestaId == id);
        }
    }
}
