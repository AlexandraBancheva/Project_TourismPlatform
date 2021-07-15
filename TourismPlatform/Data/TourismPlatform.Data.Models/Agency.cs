namespace TourismPlatform.Data.Models
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;

    public class Agency : IdentityUser
    {
        public Agency()
        {
            this.Offerts = new HashSet<Offert>();
        }

        public string AgencyName { get; set; }

        // Should make regular expression!
        public string LicenseNumber { get; set; }

        public virtual ICollection<Offert> Offerts { get; set; }
    }
}
