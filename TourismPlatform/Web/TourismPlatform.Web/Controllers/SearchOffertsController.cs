namespace TourismPlatform.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TourismPlatform.Services.Data;
    using TourismPlatform.Web.ViewModels.Offerts;
    using TourismPlatform.Web.ViewModels.SearchOfferts;

    public class SearchOffertsController : BaseController
    {
        private readonly ICategoriesService categoriesService;
        private readonly IOffertsService offertsService;

        public SearchOffertsController(ICategoriesService categoriesService, IOffertsService offertsService)
        {
            this.categoriesService = categoriesService;
            this.offertsService = offertsService;
        }

        public IActionResult Index()
        {
            var viewModel = new ListCategoriesViewModel
            {
                Offerts = this.categoriesService.GetAllCategories<CategoryNameIdViewModel>(),
            };
            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult List(SearchCategoryIdInputModel model)
        {
            var viewModel = new ListOffertsByCategoryViewModel
            {
                OffertsBySearchedCategory = (IEnumerable<OffertListViewModel>)this.offertsService.GetByCategory<OffertListViewModel>(model.CategoryId),
            };

            return this.View(viewModel);
        }
    }
}
