namespace TourismPlatform.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TourismPlatform.Data.Common.Repositories;
    using TourismPlatform.Data.Models;
    using TourismPlatform.Web.ViewModels.Offerts;

    public class OffertsService : IOffertsService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };
        private readonly IDeletableEntityRepository<Offert> offertRepository;

        public OffertsService(IDeletableEntityRepository<Offert> offertRepository)
        {
            this.offertRepository = offertRepository;
        }

        // I should add agencyId when I make a users/ agents!!! => error because of AgentId is null
        public async Task CreateAsync(OffertFormModel model, string imagePath)
        {
            var offert = new Offert
            {
                FullName = model.Name,
                StartDate = model.StartTrip,
                EndDate = model.EndTrip,
                TransportId = model.TransportId,
                CategoryId = model.CategoryId,
                PricePerPerson = model.Price,
                PriceIncludes = model.PriceIncludes,
                PriceDoesNotInclude = model.PriceDoesNotInclude,
            };

            Directory.CreateDirectory($"{imagePath}/offerts/");
            foreach (var image in model.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');
                if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extension {extension}");
                }

                var dbImage = new Image
                {
                    Extension = extension,
                };
                offert.Gallery.Add(dbImage);

                var physicalPath = $"{imagePath}/offerts/{dbImage.Id}.{extension}";
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            await this.offertRepository.AddAsync(offert);
            await this.offertRepository.SaveChangesAsync();
        }
    }
}
