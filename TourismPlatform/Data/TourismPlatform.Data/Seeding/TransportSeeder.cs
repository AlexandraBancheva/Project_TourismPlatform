namespace TourismPlatform.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TourismPlatform.Data.Models;

    public class TransportSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Transports.Any())
            {
                return;
            }

            await dbContext.Transports.AddAsync(new Transport
            {
                Name = "Индивидуален",
            });

            await dbContext.Transports.AddAsync(new Transport
            {
                Name = "Самолетен",
            });

            await dbContext.Transports.AddAsync(new Transport
            {
                Name = "Автобусен",
            });
        }
    }
}
