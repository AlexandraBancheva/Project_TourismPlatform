namespace TourismPlatform.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using TourismPlatform.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public string OffertId { get; set; }

        public virtual Offert Offert { get; set; }

        public string ApplicationId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public byte Value { get; set; }
    }
}
