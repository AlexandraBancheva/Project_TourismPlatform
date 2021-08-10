namespace TourismPlatform.Web.ViewModels.Offerts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Http;

    public class EditOffertFormModel
    {

        public string Id { get; set; }

        [Required]
        [MinLength(5)]
        [Display(Name = "Full name of program")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Start trip")]
        public DateTime StartTrip { get; set; }

        [Required]
        [Display(Name = "End trip")]
        public DateTime EndTrip { get; set; }

        [Required]
        [Display(Name = "Transport")]
        public string TransportId { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string CategoryId { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity)]
        public decimal Price { get; set; }

        [Required]
        [MinLength(30)]
        [Display(Name = "Price includes")]
        public string PriceIncludes { get; set; }

        [Required]
        [MinLength(30)]
        [Display(Name = "Price does not include")]
        public string PriceDoesNotInclude { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoryItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> TransportItems { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }
    }
}
