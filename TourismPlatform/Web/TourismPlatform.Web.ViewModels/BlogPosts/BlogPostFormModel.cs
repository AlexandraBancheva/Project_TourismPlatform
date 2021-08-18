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
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Съдържание")]
        [MinLength(20)]
        public string Content { get; set; }

        public string AuthorId { get; set; }
    }
}
