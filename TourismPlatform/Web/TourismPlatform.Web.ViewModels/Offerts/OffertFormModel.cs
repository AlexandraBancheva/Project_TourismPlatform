namespace TourismPlatform.Web.ViewModels.Offerts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class OffertFormModel
    {
        [Required]
        [MinLength(5)]
        [Display(Name = "Име на програмата")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Начална дата")]
        public DateTime StartTrip { get; set; }

        [Required]
        [Display(Name = "Крайна дата")]
        public DateTime EndTrip { get; set; }

        [Required]
        [Display(Name = "Транспорт")]
        public string TransportId { get; set; }

        [Required]
        [Display(Name = "Категория")]
        public string CategoryId { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity)]
        [Display(Name = "Цена на човек")]
        public decimal Price { get; set; }

        [Required]
        [MinLength(30)]
        [Display(Name = "Цената включва")]
        public string PriceIncludes { get; set; }

        [Required]
        [MinLength(30)]
        [Display(Name = "Цената не включва")]
        public string PriceDoesNotInclude { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoryItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> TransportItems { get; set; }

        [Required]
        [Display(Name = "Добавяне на снимки")]
        public IEnumerable<IFormFile> Images { get; set; }
    }
}
