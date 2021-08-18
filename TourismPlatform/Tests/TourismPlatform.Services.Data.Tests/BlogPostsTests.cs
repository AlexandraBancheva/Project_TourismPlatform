namespace TourismPlatform.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Moq;
    using TourismPlatform.Data.Common.Repositories;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Web.ViewModels.BlogPosts;
    using Xunit;

    public class BlogPostsTests
    {
        [Fact]
        public async Task BlogPostServiceShouldWorksCorrectly()
        {
            var list = new List<BlogPost>();
            var mockRepo = new Mock<IDeletableEntityRepository<BlogPost>>();
            mockRepo.Setup(x => x.All()).Returns(list.AsQueryable());
            mockRepo.Setup(x => x.AddAsync(It.IsAny<BlogPost>())).Callback((BlogPost blogPost) => list.Add(blogPost));
            var service = new BlogPostsService(mockRepo.Object);

            var model = new BlogPostFormModel
            {
                Title = "Test",
                Content = "TestTestTest",
            };

            await service.AddSync(model, "alex");

            Assert.Equal(1, list.Count);
            Assert.Equal(1, service.GetCount());
        }
    }
}