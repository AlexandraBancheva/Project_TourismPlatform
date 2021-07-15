using System;

namespace TourismPlatform.Data.Models
{

    public class Error
    {
        public string Id => Guid.NewGuid().ToString();

        public string OffertId { get; set; }

        public Offert Offert { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string Description { get; set; }
    }
}
