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
    using TourismPlatform.Services.Mapping;
    using TourismPlatform.Web.ViewModels.Home;
    using TourismPlatform.Web.ViewModels.Offerts;

    public class OffertsService : IOffertsService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };
        private readonly IDeletableEntityRepository<Offert> offertRepository;

        public OffertsService(IDeletableEntityRepository<Offert> offertRepository)
        {
            this.offertRepository = offertRepository;
        }

        public async Task CreateAsync(OffertFormModel model, string userId, string imagePath)
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
                CreatedApplicationUserId = userId,
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

        public async Task DeleteAsync(string id)
        {
            var offert = this.offertRepository.All().FirstOrDefault(x => x.Id == id);
            this.offertRepository.Delete(offert);
            await this.offertRepository.SaveChangesAsync();
        }

        public IEnumerable<OffertListViewModel> GetAll(int page, int itemsPerPage = 12)
        {
            var offerts = this.offertRepository.AllAsNoTracking().OrderByDescending(x => x.Id).Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .Select(x => new OffertListViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    TransportId = x.TransportId,
                    TransportName = x.Transport.Name,
                    StartDate = x.StartDate.Date,
                    EndDate = x.EndDate.Date,
                    PricePerPerson = x.PricePerPerson,
                    ImageUrl = "/images/offerts/" + x.Gallery.FirstOrDefault().Id + "." + x.Gallery.FirstOrDefault().Extension,
                })
                .ToList();

            return offerts;
        }

        public T GetById<T>(string id)
        {
            var offert = this.offertRepository.AllAsNoTracking()
                .Where(x => x.Id == id).To<T>().FirstOrDefault();
            return offert;
        }

        public int GetCount()
        {
           return this.offertRepository.All().Count();
        }

        public IEnumerable<MyAllOffertViewModel> GetMyAll(string userId, int page, int itemsPerPage = 12)
        {
            var all = this.offertRepository.All()
                .Where(x => x.CreatedApplicationUserId == userId)
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Select(x => new MyAllOffertViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    ImageUrl = "/images/offerts/" + x.Gallery.FirstOrDefault().Id + "." + x.Gallery.FirstOrDefault().Extension,
                })
                .ToList();

            return all;
        }

        public IEnumerable<HomeOffertInListViewModel> GetRandom(int count)
        {
            var randomOfferts = this.offertRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .Take(count)
                .Select(x => new HomeOffertInListViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    ImageUrl = "/images/offerts/" + x.Gallery.FirstOrDefault().Id + "." + x.Gallery.FirstOrDefault().Extension,
                })
                .ToList();

            return randomOfferts;
        }

        public async Task UpdateAsync(string id, EditOffertFormModel model)
        {
            var offert = this.offertRepository.All().FirstOrDefault(x => x.Id == id);
            offert.FullName = model.Name;
            offert.TransportId = model.TransportId;
            offert.CategoryId = model.CategoryId;
            offert.StartDate = model.StartTrip;
            offert.EndDate = model.EndTrip;
            offert.PricePerPerson = model.Price;
            offert.PriceIncludes = model.PriceIncludes;
            offert.PriceDoesNotInclude = model.PriceDoesNotInclude;

            await this.offertRepository.SaveChangesAsync();
        }
    }
}
