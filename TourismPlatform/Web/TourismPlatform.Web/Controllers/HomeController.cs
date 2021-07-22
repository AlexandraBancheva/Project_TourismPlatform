namespace TourismPlatform.Web.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using TourismPlatform.Data.Common.Repositories;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Web.ViewModels;

    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<Offert> offertRepository;

        public HomeController(IDeletableEntityRepository<Offert> offertRepository)
        {
            this.offertRepository = offertRepository;
        }

        public IActionResult Index()
        {
            var viewModel = this.offertRepository.All().Select(x => new Offert
            {
                FullName = x.FullName,
                StartDate = x.StartDate.Date,
                EndDate = x.EndDate.Date,
                Transport = x.Transport,
                Category = x.Category,
                PricePerPerson = x.PricePerPerson,
                PriceIncludes = x.PriceIncludes,
                PriceDoesNotInclude = x.PriceDoesNotInclude,
                Agency = x.Agency,
            });

            return this.View(viewModel);
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
