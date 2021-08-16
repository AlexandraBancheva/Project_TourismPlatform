namespace TourismPlatform.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    using TourismPlatform.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        [ForeignKey(nameof(Offert))]
        public string OffertId { get; set; }

        public virtual Offert Offert { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public byte Value { get; set; }
    }
}
