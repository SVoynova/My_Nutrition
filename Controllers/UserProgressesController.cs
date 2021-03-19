using System.IO;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Nutrition.Data;
using My_Nutrition.Models;
using Grpc.Core;

namespace My_Nutrition.Controllers
{
    public class UserProgressesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserProgressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserProgresses
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserProgress.ToListAsync());
        }

        // GET: UserProgresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userProgress = await _context.UserProgress
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userProgress == null)
            {
                return NotFound();
            }

            return View(userProgress);
        }

        // GET: UserProgresses/Create
        public IActionResult Create()
        {
            return View();
        }



        // POST: UserProgresses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Weight,WaistMeasurements,ArmMeasurements,LegMeasurements")] UserProgress userProgress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userProgress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userProgress);
        }

        // GET: UserProgresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userProgress = await _context.UserProgress.FindAsync(id);
            if (userProgress == null)
            {
                return NotFound();
            }
            return View(userProgress);
        }

        // POST: UserProgresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Weight,WaistMeasurements,ArmMeasurements,LegMeasurements")] UserProgress userProgress)
        {
            if (id != userProgress.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userProgress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserProgressExists(userProgress.Id))
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
            return View(userProgress);
        }

        // GET: UserProgresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userProgress = await _context.UserProgress
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userProgress == null)
            {
                return NotFound();
            }

            return View(userProgress);
        }

        // POST: UserProgresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userProgress = await _context.UserProgress.FindAsync(id);
            _context.UserProgress.Remove(userProgress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserProgressExists(int id)
        {
            return _context.UserProgress.Any(e => e.Id == id);
        }

    }
}
