namespace TourismPlatform.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    using TourismPlatform.Data.Common.Models;

    public class BlogImage : BaseDeletableModel<int>
    {
        [Required]
        [ForeignKey(nameof(BlogPost))]
        public int BlogPostId { get; set; }

        public virtual BlogPost BlogPost { get; set; }

        public string Extension { get; set; }
    }
}
