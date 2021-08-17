namespace TourismPlatform.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using TourismPlatform.Web.ViewModels.BlogPosts;

    public interface IBlogPostsService
    {
        Task AddSync(BlogPostFormModel model, string authorId, string imagePath);
    }
}
