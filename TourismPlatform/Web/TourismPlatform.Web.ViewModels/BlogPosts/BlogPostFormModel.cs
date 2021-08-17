namespace TourismPlatform.Web.ViewModels.BlogPosts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Http;

    public class BlogPostFormModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Content")]
        [MinLength(20)]
        public string Content { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [Required]
        [Display(Name = "Upload an image")]
        public IFormFile ImageUrl { get; set; }
    }
}
