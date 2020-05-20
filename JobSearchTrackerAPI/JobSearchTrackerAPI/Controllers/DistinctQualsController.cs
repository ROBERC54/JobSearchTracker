using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobSearchTrackerAPI.Data;
using JobSearchTrackerAPI.Models;

namespace JobSearchTrackerAPI.Controllers
{
    public class DistinctQualsController : Controller
    {
        private readonly JobSearchTrackerAPIContext _context;

        public DistinctQualsController(JobSearchTrackerAPIContext context)
        {
            _context = context;
        }

        // GET: DistinctQuals
        public async Task<IActionResult> Index()
        {
            return View(await _context.DistinctQual.ToListAsync());
        }

        // GET: DistinctQuals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distinctQual = await _context.DistinctQual
                .FirstOrDefaultAsync(m => m.Id == id);
            if (distinctQual == null)
            {
                return NotFound();
            }

            return View(distinctQual);
        }

        // GET: DistinctQuals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DistinctQuals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Term")] DistinctQual distinctQual)
        {
            if (ModelState.IsValid)
            {
                _context.Add(distinctQual);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(distinctQual);
        }

        // GET: DistinctQuals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distinctQual = await _context.DistinctQual.FindAsync(id);
            if (distinctQual == null)
            {
                return NotFound();
            }
            return View(distinctQual);
        }

        // POST: DistinctQuals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Term")] DistinctQual distinctQual)
        {
            if (id != distinctQual.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(distinctQual);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistinctQualExists(distinctQual.Id))
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
            return View(distinctQual);
        }

        // GET: DistinctQuals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distinctQual = await _context.DistinctQual
                .FirstOrDefaultAsync(m => m.Id == id);
            if (distinctQual == null)
            {
                return NotFound();
            }

            return View(distinctQual);
        }

        // POST: DistinctQuals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var distinctQual = await _context.DistinctQual.FindAsync(id);
            _context.DistinctQual.Remove(distinctQual);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DistinctQualExists(int id)
        {
            return _context.DistinctQual.Any(e => e.Id == id);
        }
    }
}
