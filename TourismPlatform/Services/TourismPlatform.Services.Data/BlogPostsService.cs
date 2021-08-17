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
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };
        private readonly IDeletableEntityRepository<BlogPost> blogPostsRepository;

        public BlogPostsService(IDeletableEntityRepository<BlogPost> blogPostsRepository)
        {
            this.blogPostsRepository = blogPostsRepository;
        }

        public async Task AddSync(BlogPostFormModel model, string authorId, string imagePath)
        {
            var blogPost = new BlogPost
            {
                Title = model.Title,
                Content = model.Content,
                AuthorId = authorId,
            };

            Directory.CreateDirectory($"{imagePath}/blogPostImages/");
            var image = model.ImageUrl;
            var extension = Path.GetExtension(image.FileName).TrimStart('.');
            if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
            {
                throw new Exception($"Invalid image extension {extension}");
            }

            var dbImage = new BlogImage
            {
                Extension = extension,
            };

            blogPost.ImageUrl = dbImage;

            var physicalPath = $"{imagePath}/blogPostImages/{dbImage.Id}.{extension}";
            using Stream fileStream = new FileStream(physicalPath, FileMode.Create);

            await image.CopyToAsync(fileStream);

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
                    ImageUrl = "/blogPostImages/blogPostImages/" + x.ImageUrl.Id + "." + x.ImageUrl.Extension,
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
    }
}
