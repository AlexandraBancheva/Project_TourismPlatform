namespace TourismPlatform.Web.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using TourismPlatform.Common;
    using TourismPlatform.Data.Common.Repositories;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Data;
    using TourismPlatform.Web.ViewModels;
    using TourismPlatform.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<Offert> offertRepository;
        private readonly IOffertsService offertsService;

        public HomeController(IDeletableEntityRepository<Offert> offertRepository, IOffertsService offertsService)
        {
            this.offertRepository = offertRepository;
            this.offertsService = offertsService;
        }

        public IActionResult Index()
        {

            var randomOfferts = this.offertsService.GetRandom(GlobalConstants.RandomNumbersOfOfferts).ToList();
            return this.View(randomOfferts);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
