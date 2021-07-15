namespace TourismPlatform.Data.Models
{
    using System;
    using System.Collections.Generic;
    using TourismPlatform.Data.Models.Enums;

    public class Offert
    {
        public Offert()
        {
            this.Users = new HashSet<ApplicationUser>();
        }

        public string Id => Guid.NewGuid().ToString();

        public string FullName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TransportType Transport { get; set; }

        public decimal PricePerPerson { get; set; }

        public string PriceIncludes { get; set; }

        public string PriceDoesNotInclude { get; set; }

        public string TripProgram { get; set; }

        // TODO: ICollection from Images => Gallery
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
