namespace TourismPlatform.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using TourismPlatform.Services.Data;
    using TourismPlatform.Web.ViewModels.Offerts;

    public class OffertsController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly ITransportsService transportsService;
        private readonly IOffertsService offertsService;
        private readonly IWebHostEnvironment environment;

        public OffertsController(ICategoriesService categoriesService, ITransportsService transportsService, IOffertsService offertsService, IWebHostEnvironment environment)
        {
            this.categoriesService = categoriesService;
            this.transportsService = transportsService;
            this.offertsService = offertsService;
            this.environment = environment;
        }

       //// [Authorize]
        public IActionResult Create()
        {
            var viewModel = new OffertFormModel();
            viewModel.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
            viewModel.TransportItems = this.transportsService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
      //// [Authorize]
        public async Task<IActionResult> Create(OffertFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                model.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
                model.TransportItems = this.transportsService.GetAllAsKeyValuePairs();
                return this.View();
            }

            try
            {
                await this.offertsService.CreateAsync(model, $"{this.environment.WebRootPath}/images");
            }
            catch (Exception ex)
            {

                this.ModelState.AddModelError(string.Empty, ex.Message);
                model.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
                model.TransportItems = this.transportsService.GetAllAsKeyValuePairs();

                return this.View(model);
            }

            /// Redirect to all offerts
            return this.Redirect("/");
        }
    }
}
