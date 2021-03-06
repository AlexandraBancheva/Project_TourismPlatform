namespace TourismPlatform.Web.ViewModels.BlogPosts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AutoMapper;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Mapping;

    public class BlogPostViewModel : IMapFrom<BlogPost>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string ImageUrl { get; set; }
    }
}
