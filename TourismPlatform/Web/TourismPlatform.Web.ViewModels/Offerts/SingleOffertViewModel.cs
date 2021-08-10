namespace TourismPlatform.Web.ViewModels.Offerts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SingleOffertViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime StartTrip { get; set; }

        public DateTime EndTrip { get; set; }

        public string TransportId { get; set; }

        public string CategoryId { get; set; }

        public decimal Price { get; set; }

        public string PriceIncludes { get; set; }

        public string PriceDoesNotInclude { get; set; }
    }
}
