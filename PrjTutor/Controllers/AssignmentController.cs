using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrjTutor;
using PrjTutor.Data;
using PrjTutor.Models;

namespace PrjTutor.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AssignmentController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Assignment
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            var assignments = currentUser != null 
            ? await _context.Assignment 
                .Where(a => a.UserId == currentUser.Id)
                .Include(a => a.Evaluations) // Include Evaluations
                .ThenInclude(e => e.Student) // Include related Students
                .ToListAsync()
                : new List<Assignment>();

            // ViewData["AverageGrades"] = averageGrades;

            return View(assignments);
        }

        // GET: Assignment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Assignment == null)
            {
                return NotFound();
            }

            var assignment = await _context.Assignment
                .FirstOrDefaultAsync(m => m.AssignmentId == id);
            if (assignment == null)
            {
                return NotFound();
            }

            return View(assignment);
        }

        // GET: Assignment/Create
public IActionResult Create()
{
    var assignmentTypes = Enum.GetValues(typeof(AssignmentType));
    var assignmentTypeList = new List<SelectListItem>();
    
    foreach (AssignmentType type in assignmentTypes)
    {
        assignmentTypeList.Add(new SelectListItem
        {
            Value = type.ToString(),
            Text = type.ToString() // or you can format the string as needed
        });
    }
    
    ViewData["AssignmentTypes"] = assignmentTypeList;
    
    return View();
}

        // POST: Assignment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,DueDate,Type")] Assignment assignment)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            // if (ModelState.IsValid)
            // {
            assignment.UserId = currentUser!.Id;
            _context.Add(assignment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            // }
            // var assignmentTypes = Enum.GetValues(typeof(AssignmentType));
            // var assignmentTypeList = new List<SelectListItem>();

            // foreach (AssignmentType type in assignmentTypes)
            // {
            //     assignmentTypeList.Add(new SelectListItem
            //     {
            //         Value = type.ToString(),
            //         Text = type.ToString()
            //     });
            // }
            // ViewData["AssignmentTypes"] = assignmentTypeList;

            // return View(assignment); // Return the view with the current model to show validation errors
        }

        // GET: Assignment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Assignment == null)
            {
                return NotFound();
            }

            var assignment = await _context.Assignment.FindAsync(id);
            if (assignment == null)
            {
                return NotFound();
            }
            return View(assignment);
        }

        // POST: Assignment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssignmentId,Title,DueDate,Type")] Assignment assignment)
        {
            if (id != assignment.AssignmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assignment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssignmentExists(assignment.AssignmentId))
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
            return View(assignment);
        }

        // GET: Assignment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Assignment == null)
            {
                return NotFound();
            }

            var assignment = await _context.Assignment
                .FirstOrDefaultAsync(m => m.AssignmentId == id);
            if (assignment == null)
            {
                return NotFound();
            }

            return View(assignment);
        }

        // POST: Assignment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Assignment == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Assignment'  is null.");
            }
            var assignment = await _context.Assignment.FindAsync(id);
            if (assignment != null)
            {
                _context.Assignment.Remove(assignment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssignmentExists(int id)
        {
          return (_context.Assignment?.Any(e => e.AssignmentId == id)).GetValueOrDefault();
        }
    }
}
