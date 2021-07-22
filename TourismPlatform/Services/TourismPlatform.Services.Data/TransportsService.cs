namespace TourismPlatform.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using TourismPlatform.Data.Common.Repositories;
    using TourismPlatform.Data.Models;

    public class TransportsService : ITransportsService
    {
        private readonly IDeletableEntityRepository<Transport> transportRepository;

        public TransportsService(IDeletableEntityRepository<Transport> transportRepository)
        {
            this.transportRepository = transportRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
           return this.transportRepository.All().Select(x => new
            {
                x.Id,
                x.Name,
            })
                .ToList()
                .Select(x => new KeyValuePair<string, string>(x.Id, x.Name));
        }
    }
}
