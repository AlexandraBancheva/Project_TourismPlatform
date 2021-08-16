namespace TourismPlatform.Web.ViewModels.SearchOfferts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using TourismPlatform.Web.ViewModels.Offerts;

    public class ListOffertsByCategoryViewModel
    {
        public IEnumerable<OffertListViewModel> OffertsBySearchedCategory { get; set; }
    }
}
