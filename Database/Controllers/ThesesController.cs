using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GraduationDatabase.Data;
using GraduationDatabase.Models;

namespace GraduationDatabase.Controllers
{
    public class ThesesController : Controller
    {
        private readonly WebDbContext _context;

        public ThesesController(WebDbContext context)
        {
            _context = context;
        }

        // GET: Theses
        public async Task<IActionResult> Index()
        {
            var webDbContext = _context.Theses.Include(t => t.Student).Include(t => t.Supervisor);
            return View(await webDbContext.ToListAsync());
        }

        // GET: Theses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thesis = await _context.Theses
                .Include(t => t.Student)
                .Include(t => t.Supervisor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thesis == null)
            {
                return NotFound();
            }

            return View(thesis);
        }

        // GET: Theses/Create
        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id");
            ViewData["SupervisorId"] = new SelectList(_context.Supervisors, "Id", "Id");
            return View();
        }

        // POST: Theses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,StudentId,SupervisorId")] Thesis thesis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thesis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", thesis.StudentId);
            ViewData["SupervisorId"] = new SelectList(_context.Supervisors, "Id", "Id", thesis.SupervisorId);
            return View(thesis);
        }

        // GET: Theses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thesis = await _context.Theses.FindAsync(id);
            if (thesis == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", thesis.StudentId);
            ViewData["SupervisorId"] = new SelectList(_context.Supervisors, "Id", "Id", thesis.SupervisorId);
            return View(thesis);
        }

        // POST: Theses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,StudentId,SupervisorId")] Thesis thesis)
        {
            if (id != thesis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thesis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThesisExists(thesis.Id))
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
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", thesis.StudentId);
            ViewData["SupervisorId"] = new SelectList(_context.Supervisors, "Id", "Id", thesis.SupervisorId);
            return View(thesis);
        }

        // GET: Theses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thesis = await _context.Theses
                .Include(t => t.Student)
                .Include(t => t.Supervisor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thesis == null)
            {
                return NotFound();
            }

            return View(thesis);
        }

        // POST: Theses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thesis = await _context.Theses.FindAsync(id);
            if (thesis != null)
            {
                _context.Theses.Remove(thesis);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThesisExists(int id)
        {
            return _context.Theses.Any(e => e.Id == id);
        }
    }
}
