namespace TourismPlatform.Web.ViewModels.SearchOfferts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Mapping;

    public class CategoryNameIdViewModel : IMapFrom<Category>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
