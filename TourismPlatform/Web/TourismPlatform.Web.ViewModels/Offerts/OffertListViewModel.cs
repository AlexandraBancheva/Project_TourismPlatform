namespace TourismPlatform.Web.ViewModels.Offerts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AutoMapper;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Mapping;

    public class OffertListViewModel : IMapFrom<Offert>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string ImageUrl { get; set; }

        public string TransportId { get; set; }

        public string TransportName { get; set; }

        public DateTime StartDate{ get; set; }

        public DateTime EndDate{ get; set; }

        public decimal PricePerPerson { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Offert, OffertListViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                opt.MapFrom(i => "/images/offerts/" + i.Gallery.FirstOrDefault().Id + "." + i.Gallery.FirstOrDefault().Extension));
        }
    }
}
