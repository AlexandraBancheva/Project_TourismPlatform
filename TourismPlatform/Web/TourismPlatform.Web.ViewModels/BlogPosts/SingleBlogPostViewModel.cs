namespace TourismPlatform.Web.ViewModels.BlogPosts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AutoMapper;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Mapping;

    public class SingleBlogPostViewModel : IMapFrom<BlogPost>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string ImageUrl { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<BlogPost, SingleBlogPostViewModel>()
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x => "/blogPostImages/blogPostImages/" + x.ImageUrl.Id + "." + x.ImageUrl.Extension));
        }
    }
}
