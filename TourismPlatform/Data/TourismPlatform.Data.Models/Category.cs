namespace TourismPlatform.Data.Models
{
    using System;
    using System.Collections.Generic;

    using TourismPlatform.Data.Common.Models;

    public class Category : BaseDeletableModel<string>
    {
        public Category()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Offerts = new HashSet<Offert>();
        }

        public string Name { get; set; }

        public virtual ICollection<Offert> Offerts { get; set; }
    }
}
