using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrjTutor;
using PrjTutor.Data;

namespace PrjTutor.Controllers
{
    public class EvaluationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EvaluationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Evaluation
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Evaluation.Include(e => e.Assignment).Include(e => e.Student);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Evaluation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Evaluation == null)
            {
                return NotFound();
            }

            var evaluation = await _context.Evaluation
                .Include(e => e.Assignment)
                .Include(e => e.Student)
                .FirstOrDefaultAsync(m => m.EvaluationId == id);
            if (evaluation == null)
            {
                return NotFound();
            }

            return View(evaluation);
        }

        // GET: Evaluation/Create/
        public IActionResult Create()
        {
            // Log the received student ID for debugging
            Console.WriteLine("Student ID: " + RouteData.Values["id"]);


            // Populate dropdowns
            ViewData["AssignmentId"] = new SelectList(_context.Assignment, "AssignmentId", "Title");
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "Name", RouteData.Values["id"]); // Pre-select if id is provided

            return View();
        }


        // POST: Evaluation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EvaluationId,Notes,Grade,StudentId,AssignmentId")] Evaluation evaluation)
        {
            // if (ModelState.IsValid)
            // {
                _context.Add(evaluation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            // }
            ViewData["AssignmentId"] = new SelectList(_context.Assignment, "AssignmentId", "AssignmentId", evaluation.AssignmentId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId", evaluation.StudentId);
            return View(evaluation);
        }

        // GET: Evaluation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Evaluation == null)
            {
                return NotFound();
            }

            var evaluation = await _context.Evaluation.FindAsync(id);
            if (evaluation == null)
            {
                return NotFound();
            }
            ViewData["AssignmentId"] = new SelectList(_context.Assignment, "AssignmentId", "AssignmentId", evaluation.AssignmentId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId", evaluation.StudentId);
            return View(evaluation);
        }

        // POST: Evaluation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EvaluationId, Notes,Grade,StudentId,AssignmentId")] Evaluation evaluation)
        {
            if (id != evaluation.EvaluationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(evaluation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EvaluationExists(evaluation.EvaluationId))
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
            ViewData["AssignmentId"] = new SelectList(_context.Assignment, "AssignmentId", "AssignmentId", evaluation.AssignmentId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId", evaluation.StudentId);
            return View(evaluation);
        }

        // GET: Evaluation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Evaluation == null)
            {
                return NotFound();
            }

            var evaluation = await _context.Evaluation
                .Include(e => e.Assignment)
                .Include(e => e.Student)
                .FirstOrDefaultAsync(m => m.EvaluationId == id);
            if (evaluation == null)
            {
                return NotFound();
            }

            return View(evaluation);
        }

        // POST: Evaluation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Evaluation == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Evaluation'  is null.");
            }
            var evaluation = await _context.Evaluation.FindAsync(id);
            if (evaluation != null)
            {
                _context.Evaluation.Remove(evaluation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EvaluationExists(int id)
        {
          return (_context.Evaluation?.Any(e => e.EvaluationId == id)).GetValueOrDefault();
        }
    }
}
