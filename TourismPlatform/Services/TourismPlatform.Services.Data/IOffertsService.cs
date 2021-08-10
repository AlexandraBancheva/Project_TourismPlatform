namespace TourismPlatform.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using TourismPlatform.Web.ViewModels.Home;
    using TourismPlatform.Web.ViewModels.Offerts;

    public interface IOffertsService
    {
        Task CreateAsync(OffertFormModel model, string userId, string imagePath);

        IEnumerable<OffertListViewModel> GetAll(int page, int itemsPerPage = 12);

        int GetCount();

        IEnumerable<HomeOffertInListViewModel> GetRandom(int count);

        IEnumerable<MyAllOffertViewModel> GetMyAll(string userId, int page, int itemsPerPage = 12);

        Task DeleteAsync(string id);

        Task UpdateAsync(string id, EditOffertFormModel model);

        T GetById<T>(string id);
    }
}
