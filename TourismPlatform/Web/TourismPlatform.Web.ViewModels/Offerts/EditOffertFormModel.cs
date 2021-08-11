namespace TourismPlatform.Web.ViewModels.Offerts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Http;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Services.Mapping;

    public class EditOffertFormModel : IMapFrom<Offert>
    {

        public string Id { get; set; }

        [Required]
        [MinLength(5)]
        public string FullName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string TransportId { get; set; }

        [Required]
        public string CategoryId { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity)]
        public decimal PricePerPerson { get; set; }

        [Required]
        [MinLength(30)]
        public string PriceIncludes { get; set; }

        [Required]
        [MinLength(30)]
        public string PriceDoesNotInclude { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoryItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> TransportItems { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }
    }
}
