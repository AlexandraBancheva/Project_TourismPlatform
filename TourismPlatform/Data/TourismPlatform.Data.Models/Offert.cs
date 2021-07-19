namespace TourismPlatform.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using TourismPlatform.Data.Common.Models;

    public class Offert : BaseDeletableModel<string>
    {
        public Offert()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Users = new HashSet<ApplicationUser>();
            this.Gallery = new HashSet<Image>();
        }

        [Required]
        public string FullName { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public string CategoryId { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [ForeignKey(nameof(Transport))]
        public string TransportId { get; set; }

        [Required]
        public Transport Transport { get; set; }

        public decimal PricePerPerson { get; set; }

        [Required]
        public string PriceIncludes { get; set; }

        [Required]
        public string PriceDoesNotInclude { get; set; }

        [Required]
        public string TripProgram { get; set; }

        [Required]
        [ForeignKey(nameof(Agency))]
        public string AgencyId { get; set; }

        public virtual Agency Agency { get; set; }

        public virtual ICollection<Image> Gallery { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
