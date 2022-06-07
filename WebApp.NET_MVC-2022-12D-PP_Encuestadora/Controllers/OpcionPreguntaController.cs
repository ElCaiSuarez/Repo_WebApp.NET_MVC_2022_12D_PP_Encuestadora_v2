﻿using System;
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
    public class OpcionPreguntaController : Controller
    {
        private readonly EncuestadoraDBContext _context;

        public OpcionPreguntaController(EncuestadoraDBContext context)
        {
            _context = context;
        }

        // GET: OpcionPregunta
        public async Task<IActionResult> Index()
        {
            var encuestadoraDBContext = _context.opciones.Include(o => o.Pregunta);
            return View(await encuestadoraDBContext.ToListAsync());
        }

        // GET: OpcionPregunta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcionPregunta = await _context.opciones
                .Include(o => o.Pregunta)
                .FirstOrDefaultAsync(m => m.OpcionPreguntaId == id);
            if (opcionPregunta == null)
            {
                return NotFound();
            }

            return View(opcionPregunta);
        }

        // GET: OpcionPregunta/Create
        public IActionResult Create()
        {
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta");
            return View();
        }

        // POST: OpcionPregunta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OpcionPreguntaId,tituloOpcion,opcionSeleccionada,PreguntaId")] OpcionPregunta opcionPregunta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opcionPregunta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta", opcionPregunta.PreguntaId);
            return View(opcionPregunta);
        }

        // GET: OpcionPregunta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcionPregunta = await _context.opciones.FindAsync(id);
            if (opcionPregunta == null)
            {
                return NotFound();
            }
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta", opcionPregunta.PreguntaId);
            return View(opcionPregunta);
        }

        // POST: OpcionPregunta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OpcionPreguntaId,tituloOpcion,opcionSeleccionada,PreguntaId")] OpcionPregunta opcionPregunta)
        {
            if (id != opcionPregunta.OpcionPreguntaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opcionPregunta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpcionPreguntaExists(opcionPregunta.OpcionPreguntaId))
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
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta", opcionPregunta.PreguntaId);
            return View(opcionPregunta);
        }

        // GET: OpcionPregunta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcionPregunta = await _context.opciones
                .Include(o => o.Pregunta)
                .FirstOrDefaultAsync(m => m.OpcionPreguntaId == id);
            if (opcionPregunta == null)
            {
                return NotFound();
            }

            return View(opcionPregunta);
        }

        // POST: OpcionPregunta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opcionPregunta = await _context.opciones.FindAsync(id);
            _context.opciones.Remove(opcionPregunta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpcionPreguntaExists(int id)
        {
            return _context.opciones.Any(e => e.OpcionPreguntaId == id);
        }
    }
}
