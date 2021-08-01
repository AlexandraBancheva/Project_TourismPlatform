namespace TourismPlatform.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using TourismPlatform.Data;
    using TourismPlatform.Data.Common.Repositories;
    using TourismPlatform.Data.Models;

    [Area("Administration")]
    public class OffertsController : AdministrationController
    {
        private readonly IDeletableEntityRepository<Offert> dataRepository;
        private readonly ApplicationDbContext dbContext;

        public OffertsController(IDeletableEntityRepository<Offert> dataRepository, ApplicationDbContext dbContext)
        {
            this.dataRepository = dataRepository;
            this.dbContext = dbContext;
        }

        // GET: Administration/Offerts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = this.dataRepository.All().Include(o => o.Category).Include(o => o.Transport);
            return this.View(await applicationDbContext.ToListAsync());
        }

        // GET: Administration/Offerts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var offert = await this.dataRepository.All()
                .Include(o => o.Category)
                .Include(o => o.Transport)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offert == null)
            {
                return this.NotFound();
            }

            return this.View(offert);
        }

        // GET: Administration/Offerts/Create
        public IActionResult Create()
        {
            this.ViewData["CategoryId"] = new SelectList(this.dbContext.Categories, "Id", "Id");
            this.ViewData["TransportId"] = new SelectList(this.dbContext.Transports, "Id", "Id");
            return this.View();
        }

        // POST: Administration/Offerts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,CategoryId,StartDate,EndDate,TransportId,PricePerPerson,PriceIncludes,PriceDoesNotInclude,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Offert offert)
        {
            if (this.ModelState.IsValid)
            {
                await this.dataRepository.AddAsync(offert);
                await this.dataRepository.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }
            this.ViewData["CategoryId"] = new SelectList(this.dbContext.Categories, "Id", "Id", offert.CategoryId);
            this.ViewData["TransportId"] = new SelectList(this.dbContext.Transports, "Id", "Id", offert.TransportId);
            return this.View(offert);
        }

        // GET: Administration/Offerts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var offert = this.dataRepository.All().FirstOrDefault(x => x.Id == id);
            if (offert == null)
            {
                return this.NotFound();
            }

            this.ViewData["CategoryId"] = new SelectList(this.dbContext.Categories, "Id", "Id", offert.CategoryId);
            this.ViewData["TransportId"] = new SelectList(this.dbContext.Transports, "Id", "Id", offert.TransportId);
            return this.View(offert);
        }

        // POST: Administration/Offerts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FullName,CategoryId,StartDate,EndDate,TransportId,PricePerPerson,PriceIncludes,PriceDoesNotInclude,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Offert offert)
        {
            if (id != offert.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this.dataRepository.Update(offert);
                    await this.dataRepository.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.OffertExists(offert.Id))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            this.ViewData["CategoryId"] = new SelectList(this.dbContext.Categories, "Id", "Id", offert.CategoryId);
            this.ViewData["TransportId"] = new SelectList(this.dbContext.Transports, "Id", "Id", offert.TransportId);
            return this.View(offert);
        }

        // GET: Administration/Offerts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var offert = await this.dataRepository.All()
                .Include(o => o.Category)
                .Include(o => o.Transport)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offert == null)
            {
                return this.NotFound();
            }

            return this.View(offert);
        }

        // POST: Administration/Offerts/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var offert = this.dataRepository.All().FirstOrDefault(x => x.Id == id);
            this.dataRepository.Delete(offert);
            await this.dataRepository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        private bool OffertExists(string id)
        {
            return this.dataRepository.All().Any(e => e.Id == id);
        }
    }
}
