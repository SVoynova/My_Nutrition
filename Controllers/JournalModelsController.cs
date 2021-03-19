using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using My_Nutrition.Data;
using My_Nutrition.Models;

namespace My_Nutrition.Controllers
{
    public class JournalModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JournalModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JournalModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.JournalModel.ToListAsync());
        }

        // GET: JournalModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journalModel = await _context.JournalModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (journalModel == null)
            {
                return NotFound();
            }

            return View(journalModel);
        }

        // GET: JournalModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JournalModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Thoughts,Gratitudes,Concerns,Questions")] JournalModel journalModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(journalModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(journalModel);
        }

        // GET: JournalModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journalModel = await _context.JournalModel.FindAsync(id);
            if (journalModel == null)
            {
                return NotFound();
            }
            return View(journalModel);
        }

        // POST: JournalModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Thoughts,Gratitudes,Concerns,Questions")] JournalModel journalModel)
        {
            if (id != journalModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(journalModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JournalModelExists(journalModel.Id))
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
            return View(journalModel);
        }

        // GET: JournalModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journalModel = await _context.JournalModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (journalModel == null)
            {
                return NotFound();
            }

            return View(journalModel);
        }

        // POST: JournalModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var journalModel = await _context.JournalModel.FindAsync(id);
            _context.JournalModel.Remove(journalModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JournalModelExists(int id)
        {
            return _context.JournalModel.Any(e => e.Id == id);
        }
    }
}
