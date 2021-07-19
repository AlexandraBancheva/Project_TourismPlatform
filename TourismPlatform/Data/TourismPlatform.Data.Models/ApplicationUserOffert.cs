namespace TourismPlatform.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using TourismPlatform.Data.Common.Models;

    public class ApplicationUserOffert
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [ForeignKey(nameof(Offert))]
        public string OffertId { get; set; }

        public virtual Offert Offert { get; set; }
    }
}
