using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodesWeaverNew.Data;
using CodesWeaverNew.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CodesWeaverNew.Controllers
{
    public class TestimonialsController : Controller
    {
        private readonly CodesWeaverNewContext _context;

        public TestimonialsController(CodesWeaverNewContext context)
        {
            _context = context;
        }

        // GET: Testimonials
        public async Task<IActionResult> Index()
        {
            return View(await _context.Testimonials.ToListAsync());
        }

        // GET: Testimonials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonials = await _context.Testimonials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testimonials == null)
            {
                return NotFound();
            }

            return View(testimonials);
        }

        // GET: Testimonials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Testimonials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Designation,Description,Image,willshown")] Testimonials testimonials, IFormFile Image)
        {
            if (Image.Length > 0)
            {
                using (var stream = new MemoryStream())
                {
                    await Image.CopyToAsync(stream);
                    testimonials.Image = stream.ToArray();
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(testimonials);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testimonials);
        }
        // GET: Testimonials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonials = await _context.Testimonials.FindAsync(id);
            if (testimonials == null)
            {
                return NotFound();
            }
            return View(testimonials);
        }

        // POST: Testimonials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Designation,Description,Image,willshown")] Testimonials testimonials)
        {
            if (id != testimonials.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testimonials);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestimonialsExists(testimonials.Id))
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
            return View(testimonials);
        }

        // GET: Testimonials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonials = await _context.Testimonials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testimonials == null)
            {
                return NotFound();
            }

            return View(testimonials);
        }

        // POST: Testimonials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testimonials = await _context.Testimonials.FindAsync(id);
            _context.Testimonials.Remove(testimonials);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestimonialsExists(int id)
        {
            return _context.Testimonials.Any(e => e.Id == id);
        }
    }
}
