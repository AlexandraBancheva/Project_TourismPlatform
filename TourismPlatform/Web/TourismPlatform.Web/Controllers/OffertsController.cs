namespace TourismPlatform.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TourismPlatform.Services.Data;
    using TourismPlatform.Web.ViewModels.Offerts;

    public class OffertsController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly ITransportsService transportsService;

        public OffertsController(ICategoriesService categoriesService, ITransportsService transportsService)
        {
            this.categoriesService = categoriesService;
            this.transportsService = transportsService;
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
        public IActionResult Create(OffertFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                model.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
                model.TransportItems = this.transportsService.GetAllAsKeyValuePairs();
                return this.View();
            }

            return this.Redirect("/");
        }
    }
}
