namespace TourismPlatform.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TourismPlatform.Data.Common.Repositories;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Mapping;
    using TourismPlatform.Web.ViewModels.BlogPosts;

    public class BlogPostsService : IBlogPostsService
    {
        private readonly IDeletableEntityRepository<BlogPost> blogPostsRepository;

        public BlogPostsService(IDeletableEntityRepository<BlogPost> blogPostsRepository)
        {
            this.blogPostsRepository = blogPostsRepository;
        }

        public async Task AddSync(BlogPostFormModel model, string authorId)
        {
            var blogPost = new BlogPost
            {
                Title = model.Title,
                Content = model.Content,
                AuthorId = authorId,
            };

            await this.blogPostsRepository.AddAsync(blogPost);
            await this.blogPostsRepository.SaveChangesAsync();
        }

        public IEnumerable<BlogPostViewModel> GetAll(int page, int itemsPerPage = 12)
        {
            var blogPosts = this.blogPostsRepository.AllAsNoTracking().OrderByDescending(x => x.Id).Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .Select(x => new BlogPostViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    AuthorId = x.AuthorId,
                    AuthorName = x.Author.FullName,
                })
                .ToList();

            return blogPosts;
        }

        public int GetCount()
        {
            return this.blogPostsRepository.All().Count();
        }

        public T GetById<T>(int id)
        {
            var blogPost = this.blogPostsRepository.AllAsNoTracking().Where(x => x.Id == id).To<T>().FirstOrDefault();

            return blogPost;
        }

        public async Task DeleteAsync(int id)
        {
            var blogPost = this.blogPostsRepository.All().FirstOrDefault(x => x.Id == id);
            this.blogPostsRepository.Delete(blogPost);
            await this.blogPostsRepository.SaveChangesAsync();
        }
    }
}
