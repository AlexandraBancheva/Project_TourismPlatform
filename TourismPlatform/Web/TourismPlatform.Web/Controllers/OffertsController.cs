namespace TourismPlatform.Web.Controllers
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using TourismPlatform.Common;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Data;
    using TourismPlatform.Web.ViewModels.Offerts;

    public class OffertsController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly ITransportsService transportsService;
        private readonly IOffertsService offertsService;
        private readonly IWebHostEnvironment environment;
        private readonly UserManager<ApplicationUser> userManager;

        public OffertsController(ICategoriesService categoriesService, ITransportsService transportsService, IOffertsService offertsService, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager)
        {
            this.categoriesService = categoriesService;
            this.transportsService = transportsService;
            this.offertsService = offertsService;
            this.environment = environment;
            this.userManager = userManager;
        }

        [Authorize(Roles = GlobalConstants.TravelAgentRoleName)]
        public IActionResult Create()
        {
            var viewModel = new OffertFormModel();
            viewModel.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
            viewModel.TransportItems = this.transportsService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.TravelAgentRoleName)]
        public async Task<IActionResult> Create(OffertFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                model.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
                model.TransportItems = this.transportsService.GetAllAsKeyValuePairs();
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);
            try
            {
                await this.offertsService.CreateAsync(model, user.Id, $"{this.environment.WebRootPath}/images");
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

        public IActionResult All(int id = 1)
        {
            const int ItemsPerPage = 12;
            var viewModel = new OffertsInListModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                OffertsCount = this.offertsService.GetCount(),
                Offerts = this.offertsService.GetAll(id, ItemsPerPage),
            };
            return this.View(viewModel);
        }

        [Authorize(Roles = GlobalConstants.TravelAgentRoleName)]
        public async Task<IActionResult> MyOfferts(int id = 1)
        {
            const int ItemsPerPage = 12;
            var user = await this.userManager.GetUserAsync(this.User);
            var viewModel = new MyAllOffertsViewModel
            {
                MyAllOfferts = this.offertsService.GetMyAll(user.Id, id, ItemsPerPage),
            };
            return this.View(viewModel);
        }
    }
}
