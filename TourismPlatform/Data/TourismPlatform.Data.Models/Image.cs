namespace TourismPlatform.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using TourismPlatform.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        [ForeignKey(nameof(Offert))]
        public string OffertId { get; set; }

        public virtual Offert Offert { get; set; }

        public string Extension { get; set; }
    }
}
