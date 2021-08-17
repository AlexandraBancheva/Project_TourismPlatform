namespace TourismPlatform.Web.ViewModels.Offerts
{
    using System;
    using System.Linq;

    using AutoMapper;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Mapping;

    public class SingleOffertViewModel : IMapFrom<Offert>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string TransportName { get; set; }

        public string CategoryName { get; set; }

        public decimal PricePerPerson { get; set; }

        public string PriceIncludes { get; set; }

        public string PriceDoesNotInclude { get; set; }

        public string ImageUrl { get; set; }

        public double AverageVote { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Offert, SingleOffertViewModel>()
                .ForMember(x => x.AverageVote, opt => opt.MapFrom(x => x.Votes.Count() == 0 ? 0 : x.Votes.Average(v => v.Value)))
                .ForMember(x => x.ImageUrl, opt =>
                opt.MapFrom(x => "/images/offerts/" + x.Gallery.FirstOrDefault().Id + "." + x.Gallery.FirstOrDefault().Extension));
        }
    }
}
