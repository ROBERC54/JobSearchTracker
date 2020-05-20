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
    public class JobDescriptionsController : Controller
    {
        private readonly JobSearchTrackerAPIContext _context;

        public JobDescriptionsController(JobSearchTrackerAPIContext context)
        {
            _context = context;
        }

        // GET: JobDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobDescription.ToListAsync());
        }

        // GET: JobDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobDescription = await _context.JobDescription
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobDescription == null)
            {
                return NotFound();
            }

            return View(jobDescription);
        }

        // GET: JobDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobDescriptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JDescription,DatePosted,DateApplied,Link,MinQuals,QualificationsMet,Notes")] JobDescription jobDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobDescription);
        }

        // GET: JobDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobDescription = await _context.JobDescription.FindAsync(id);
            if (jobDescription == null)
            {
                return NotFound();
            }
            return View(jobDescription);
        }

        // POST: JobDescriptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JDescription,DatePosted,DateApplied,Link,MinQuals,QualificationsMet,Notes")] JobDescription jobDescription)
        {
            if (id != jobDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobDescriptionExists(jobDescription.Id))
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
            return View(jobDescription);
        }

        // GET: JobDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobDescription = await _context.JobDescription
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobDescription == null)
            {
                return NotFound();
            }

            return View(jobDescription);
        }

        // POST: JobDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobDescription = await _context.JobDescription.FindAsync(id);
            _context.JobDescription.Remove(jobDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobDescriptionExists(int id)
        {
            return _context.JobDescription.Any(e => e.Id == id);
        }
    }
}
