namespace TourismPlatform.Web.ViewModels.Offerts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffertsInListModel
    {
        public IEnumerable<OffertListViewModel> Offerts { get; set; }

        public int PageNumber { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.OffertsCount / this.ItemsPerPage);

        public int OffertsCount { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
