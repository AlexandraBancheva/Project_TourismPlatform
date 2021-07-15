namespace TourismPlatform.Data.Models
{
    using System;
    using TourismPlatform.Data.Common.Models;

    public class Image : BaseModel<string>
    {

        public string OffertId { get; set; }

        public Offert Offert { get; set; }

        public string Extension { get; set; }

        public string Url { get; set; }
    }
}
