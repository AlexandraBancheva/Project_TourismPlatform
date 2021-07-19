namespace TourismPlatform.Data.Models
{
    using TourismPlatform.Data.Common.Models;

    public class Error
    {
        public int Id { get; set; }

        public string OffertId { get; set; }

        public Offert Offert { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string Description { get; set; }
    }
}
