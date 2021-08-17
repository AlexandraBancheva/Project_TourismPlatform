namespace TourismPlatform.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    using TourismPlatform.Common;
    using TourismPlatform.Data.Common.Models;

    public class BlogPost : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.MaxLengthTitleBlogPost)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public Image ImageUrl { get; set; }
    }
}
