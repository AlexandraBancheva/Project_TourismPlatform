namespace TourismPlatform.Web.ViewModels.Votes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class PostVoteInputModel
    {
        public string OffertId { get; set; }

        [Range(1, 5)]
        public byte Value { get; set; }
    }
}
