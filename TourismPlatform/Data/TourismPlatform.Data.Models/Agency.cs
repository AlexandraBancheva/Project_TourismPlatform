namespace TourismPlatform.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;

    public class Agency : IdentityUser
    {
        public Agency()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Offerts = new HashSet<Offert>();
        }

        [Required]
        public string AgencyName { get; set; }

        [Required]
        public string LicenseNumber { get; set; }

        public virtual ICollection<Offert> Offerts { get; set; }
    }
}
