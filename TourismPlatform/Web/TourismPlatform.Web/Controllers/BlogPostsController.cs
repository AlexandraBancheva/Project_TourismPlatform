namespace TourismPlatform.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using TourismPlatform.Common;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Data;
    using TourismPlatform.Web.ViewModels.BlogPosts;

    public class BlogPostsController : BaseController
    {
        private readonly IBlogPostsService blogPostsService;
        private readonly IWebHostEnvironment environment;
        private readonly UserManager<ApplicationUser> userManager;

        public BlogPostsController(IBlogPostsService blogPostsService, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager)
        {
            this.blogPostsService = blogPostsService;
            this.environment = environment;
            this.userManager = userManager;
        }

        [Authorize(Roles = GlobalConstants.TravelAgentRoleName)]
        public IActionResult Create()
        {
            var viewModel = new BlogPostFormModel();
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.TravelAgentRoleName)]
        public async Task<IActionResult> Create(BlogPostFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);
            try
            {
               await this.blogPostsService.AddSync(model, user.Id, $"{this.environment.WebRootPath}/blogPostImages");
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                return this.View(model);
            }

            // ToDo : Redirect to Blogs
            return this.Redirect("/");
        }
    }
}
