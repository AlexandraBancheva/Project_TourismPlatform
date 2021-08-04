namespace TourismPlatform.Web.ViewModels.Offerts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffertListViewModel
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string ImageUrl { get; set; }

        public string TransportId { get; set; }

        public string TransportName { get; set; }

        public DateTime StartDate{ get; set; }

        public DateTime EndDate{ get; set; }

        public decimal PricePerPerson { get; set; }
    }
}
