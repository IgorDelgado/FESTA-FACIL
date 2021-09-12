using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FESTA_FACIL.Models;
using FESTA_FACIL.Models.Dominio;

namespace FESTA_FACIL.Controllers
{
    public class MobiliasController : Controller
    {
        private readonly Contexto _context;

        public MobiliasController(Contexto context)
        {
            _context = context;
        }

        // GET: Mobilias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mobilias.ToListAsync());
        }

        // GET: Mobilias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobilia = await _context.Mobilias
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mobilia == null)
            {
                return NotFound();
            }

            return View(mobilia);
        }

        // GET: Mobilias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mobilias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,Descricao,Cor,Modelo")] Mobilia mobilia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mobilia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mobilia);
        }

        // GET: Mobilias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobilia = await _context.Mobilias.FindAsync(id);
            if (mobilia == null)
            {
                return NotFound();
            }
            return View(mobilia);
        }

        // POST: Mobilias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,Descricao,Cor,Modelo")] Mobilia mobilia)
        {
            if (id != mobilia.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mobilia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MobiliaExists(mobilia.ID))
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
            return View(mobilia);
        }

        // GET: Mobilias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobilia = await _context.Mobilias
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mobilia == null)
            {
                return NotFound();
            }

            return View(mobilia);
        }

        // POST: Mobilias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mobilia = await _context.Mobilias.FindAsync(id);
            _context.Mobilias.Remove(mobilia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MobiliaExists(int id)
        {
            return _context.Mobilias.Any(e => e.ID == id);
        }
    }
}
