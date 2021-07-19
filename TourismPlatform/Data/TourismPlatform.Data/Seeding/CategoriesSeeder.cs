namespace TourismPlatform.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TourismPlatform.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Културен туризъм",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Екологичен туризъм",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Морски туризъм",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Планински/ Ски туризъм",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Балнео, СПА и Уелнес",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Спортен/ Приключенски туризъм",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Селски туризъм",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Конгресен туризъм",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Къмпинг туризъм",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "Винен/ Кулинарен туризъм",
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
