using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentaCarMVC.Data;
using RentaCarMVC.Models;

namespace RentaCarMVC
{
    public class AracController : Controller
    {
        private readonly RentaCarMVCContext _context;

        public AracController(RentaCarMVCContext context)
        {
            _context = context;
        }

        // GET: Arac
        [Authorize]
        public async Task<IActionResult> Index(bool kk)
        {
            List<Arac> araclar = await _context.Arac.ToListAsync();
            List<Arac> otoArac = new List<Arac>();
          
            foreach (Arac arac in araclar)
            {
                if (arac.Vites)
                {
                    otoArac.Add(arac);
                }
            }

            if (kk)
            {
                return View(otoArac);
            }
            else
            {
                return View(araclar);
            }


            //return View(_context.Arac.ToList());

        }

        // GET: Arac/Details/5
        public async Task<IActionResult> Details(int? AracId)
        {
            if (AracId == null)
            {
                //return RedirectToAction("Index");
                return View("~/Views/Home/Index.cshtml");
            }

            var arac = await _context.Arac
                .FirstOrDefaultAsync(m => m.AracId == AracId);

            if (arac == null)
            {
                return RedirectToAction("Index");
                //return View("Index");
            }

            return View(arac);
        }

        // GET: Arac/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Arac/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AracId,Marka,Model,Yil,Vites,GunlukKira,Kilometre,Hazir,GorselUrl")] Arac arac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arac);
        }

        // GET: Arac/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            
            }

            var arac = await _context.Arac.FindAsync(id);
            if (arac == null)
            {
                return NotFound();
            }
            return View(arac);
        }

        // POST: Arac/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Arac arac)
        {
            if (id != arac.AracId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AracExists(arac.AracId))
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
            return View(arac);
        }

        // GET: Arac/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arac = await _context.Arac
                .FirstOrDefaultAsync(m => m.AracId == id);
            if (arac == null)
            {
                return NotFound();
            }

            return View(arac);
        }

        // POST: Arac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var arac = await _context.Arac.FindAsync(id);
            if (arac != null)
            {
                _context.Arac.Remove(arac);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AracExists(int id)
        {
            return _context.Arac.Any(e => e.AracId == id);
        }
    }
}
