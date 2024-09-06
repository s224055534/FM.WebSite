using FM.WebSite.Data;
using FM.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace FM.WebSite.Controllers
{
    public class FridgeAllocationController : Controller
    {
        public class FridgeAllocationsController : Controller
        {
            private readonly ManagementContext _context;

            public FridgeAllocationsController(ManagementContext context)
            {
                _context = context;
            }

            //    public async Task<IActionResult> Index()
            //    {
            //        var managementContext = _context.FridgeAllocation.Include(f => f.Customer).Include(f => f.Fridge);
            //        return View(await managementContext.ToListAsync());
            //    }


            //    public async Task<IActionResult> Details(int? id)
            //    {
            //        if (id == null)
            //        {
            //            return NotFound();
            //        }

            //        var fridgeAllocation = await _context.FridgeAllocation
            //            .Include(f => f.Customer)
            //            .Include(f => f.Fridge)
            //            .FirstOrDefaultAsync(m => m.FridgeAllocationId == id);
            //        if (fridgeAllocation == null)
            //        {
            //            return NotFound();
            //        }

            //        return View(fridgeAllocation);
            //    }

            //    public IActionResult Create()
            //    {
            //        ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "BusinessName");
            //        ViewData["FridgeId"] = new SelectList(_context.Fridge, "FridgeId", "FridgeName");
            //        return View();
            //    }


            //    [HttpPost]
            //    [ValidateAntiForgeryToken]
            //    public async Task<IActionResult> Create([Bind("FridgeAllocationId,AllocationDate,MaintananceDate,FridgeId,CustomerId")] FridgeAllocation fridgeAllocation)
            //    {
            //        if (ModelState.IsValid)
            //        {
            //            _context.Add(fridgeAllocation);
            //            await _context.SaveChangesAsync();
            //            return RedirectToAction(nameof(Index));
            //        }
            //        ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "BusinessName", fridgeAllocation.CustomerId);
            //        ViewData["FridgeId"] = new SelectList(_context.Fridge, "FridgeId", "FridgeName", fridgeAllocation.FridgeId);
            //        return View(fridgeAllocation);
            //    }

            //    public async Task<IActionResult> Edit(int? id)
            //    {
            //        if (id == null)
            //        {
            //            return NotFound();
            //        }

            //        var fridgeAllocation = await _context.FridgeAllocation.FindAsync(id);
            //        if (fridgeAllocation == null)
            //        {
            //            return NotFound();
            //        }
            //        ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "BusinessName", fridgeAllocation.CustomerId);
            //        ViewData["FridgeId"] = new SelectList(_context.Fridge, "FridgeId", "FridgeName", fridgeAllocation.FridgeId);
            //        return View(fridgeAllocation);
            //    }

            //    [HttpPost]
            //    [ValidateAntiForgeryToken]
            //    public async Task<IActionResult> Edit(int id, [Bind("FridgeAllocationId,AllocationDate,MaintananceDate,FridgeId,CustomerId")] FridgeAllocation fridgeAllocation)
            //    {
            //        if (id != fridgeAllocation.FridgeAllocationId)
            //        {
            //            return NotFound();
            //        }

            //        if (ModelState.IsValid)
            //        {
            //            try
            //            {
            //                _context.Update(fridgeAllocation);
            //                await _context.SaveChangesAsync();
            //            }
            //            catch (DbUpdateConcurrencyException)
            //            {
            //                if (!FridgeAllocationExists(fridgeAllocation.FridgeAllocationId))
            //                {
            //                    return NotFound();
            //                }
            //                else
            //                {
            //                    throw;
            //                }
            //            }
            //            return RedirectToAction(nameof(Index));
            //        }
            //        ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "BusinessName", fridgeAllocation.CustomerId);
            //        ViewData["FridgeId"] = new SelectList(_context.Fridge, "FridgeId", "FridgeName", fridgeAllocation.FridgeId);
            //        return View(fridgeAllocation);
            //    }


            //    public async Task<IActionResult> Delete(int? id)
            //    {
            //        if (id == null)
            //        {
            //            return NotFound();
            //        }

            //        var fridgeAllocation = await _context.FridgeAllocation
            //            .Include(f => f.Customer)
            //            .Include(f => f.Fridge)
            //            .FirstOrDefaultAsync(m => m.FridgeAllocationId == id);
            //        if (fridgeAllocation == null)
            //        {
            //            return NotFound();
            //        }

            //        return View(fridgeAllocation);
            //    }


            //    [HttpPost, ActionName("Delete")]
            //    [ValidateAntiForgeryToken]
            //    public async Task<IActionResult> DeleteConfirmed(int id)
            //    {
            //        var fridgeAllocation = await _context.FridgeAllocation.FindAsync(id);
            //        if (fridgeAllocation != null)
            //        {
            //            _context.FridgeAllocation.Remove(fridgeAllocation);
            //        }

            //        await _context.SaveChangesAsync();
            //        return RedirectToAction(nameof(Index));
            //    }

            //    private bool FridgeAllocationExists(int id)
            //    {
            //        return _context.FridgeAllocation.Any(e => e.FridgeAllocationId == id);
            //    }
        }

    }
}
