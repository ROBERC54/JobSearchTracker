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
    public class ParentCompaniesController : Controller
    {
        private readonly JobSearchTrackerAPIContext _context;

        public ParentCompaniesController(JobSearchTrackerAPIContext context)
        {
            _context = context;
        }

        // GET: ParentCompanies
        public async Task<IActionResult> Index()
        {
            return View(await _context.ParentCompany.ToListAsync());
        }

        // GET: ParentCompanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentCompany = await _context.ParentCompany
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parentCompany == null)
            {
                return NotFound();
            }

            return View(parentCompany);
        }

        // GET: ParentCompanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ParentCompanies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] ParentCompany parentCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parentCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parentCompany);
        }

        // GET: ParentCompanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentCompany = await _context.ParentCompany.FindAsync(id);
            if (parentCompany == null)
            {
                return NotFound();
            }
            return View(parentCompany);
        }

        // POST: ParentCompanies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] ParentCompany parentCompany)
        {
            if (id != parentCompany.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parentCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentCompanyExists(parentCompany.Id))
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
            return View(parentCompany);
        }

        // GET: ParentCompanies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentCompany = await _context.ParentCompany
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parentCompany == null)
            {
                return NotFound();
            }

            return View(parentCompany);
        }

        // POST: ParentCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parentCompany = await _context.ParentCompany.FindAsync(id);
            _context.ParentCompany.Remove(parentCompany);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParentCompanyExists(int id)
        {
            return _context.ParentCompany.Any(e => e.Id == id);
        }
    }
}
