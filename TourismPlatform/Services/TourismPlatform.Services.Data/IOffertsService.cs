namespace TourismPlatform.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using TourismPlatform.Web.ViewModels.Offerts;

    public interface IOffertsService
    {
        Task CreateAsync(OffertFormModel model, string imagePath);
    }
}
