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
    public class EncuestaUsuarioController : Controller
    {
        private readonly EncuestadoraDBContext _context;

        public EncuestaUsuarioController(EncuestadoraDBContext context)
        {
            _context = context;
        }

        // GET: EncuestaUsuario
        public async Task<IActionResult> Index()
        {
            var encuestadoraDBContext = _context.encuestasUsuarios.Include(e => e.Encuesta).Include(e => e.Usuario);
            return View(await encuestadoraDBContext.ToListAsync());
        }

        // GET: EncuestaUsuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuestasUsuarios = await _context.encuestasUsuarios
                .Include(e => e.Encuesta)
                .Include(e => e.Usuario)
                .FirstOrDefaultAsync(m => m.EncuestaId == id);
            if (encuestasUsuarios == null)
            {
                return NotFound();
            }

            return View(encuestasUsuarios);
        }

        // GET: EncuestaUsuario/Create
        public IActionResult Create()
        {
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta");
            ViewData["UsuarioId"] = new SelectList(_context.usuarios, "UsuarioId", "nombreUsuario");
            return View();
        }

        // POST: EncuestaUsuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EncuestaId,UsuarioId")] EncuestasUsuarios encuestasUsuarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(encuestasUsuarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", encuestasUsuarios.EncuestaId);
            ViewData["UsuarioId"] = new SelectList(_context.usuarios, "UsuarioId", "nombreUsuario", encuestasUsuarios.UsuarioId);
            return View(encuestasUsuarios);
        }

        // GET: EncuestaUsuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuestasUsuarios = await _context.encuestasUsuarios.FindAsync(id);
            if (encuestasUsuarios == null)
            {
                return NotFound();
            }
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", encuestasUsuarios.EncuestaId);
            ViewData["UsuarioId"] = new SelectList(_context.usuarios, "UsuarioId", "nombreUsuario", encuestasUsuarios.UsuarioId);
            return View(encuestasUsuarios);
        }

        // POST: EncuestaUsuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EncuestaId,UsuarioId")] EncuestasUsuarios encuestasUsuarios)
        {
            if (id != encuestasUsuarios.EncuestaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(encuestasUsuarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EncuestasUsuariosExists(encuestasUsuarios.EncuestaId))
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
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", encuestasUsuarios.EncuestaId);
            ViewData["UsuarioId"] = new SelectList(_context.usuarios, "UsuarioId", "nombreUsuario", encuestasUsuarios.UsuarioId);
            return View(encuestasUsuarios);
        }

        // GET: EncuestaUsuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuestasUsuarios = await _context.encuestasUsuarios
                .Include(e => e.Encuesta)
                .Include(e => e.Usuario)
                .FirstOrDefaultAsync(m => m.EncuestaId == id);
            if (encuestasUsuarios == null)
            {
                return NotFound();
            }

            return View(encuestasUsuarios);
        }

        // POST: EncuestaUsuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var encuestasUsuarios = await _context.encuestasUsuarios.FindAsync(id);
            _context.encuestasUsuarios.Remove(encuestasUsuarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EncuestasUsuariosExists(int id)
        {
            return _context.encuestasUsuarios.Any(e => e.EncuestaId == id);
        }
    }
}
