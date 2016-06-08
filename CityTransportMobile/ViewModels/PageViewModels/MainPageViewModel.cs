using CityTransportMobile.Helpers;
using CityTransportMobile.Resources;

namespace CityTransportMobile.ViewModels.PageViewModels
{
    public class MainPageViewModel : BasePageViewModel
    {
        public ContentButtonViewModel Routes { get; set; }

        public ContentButtonViewModel Favorites { get; set; }

        public ContentButtonViewModel Search { get; set; }

        public MainPageViewModel()
        {
            Routes = new ContentButtonViewModel
            {
                Text = AppResources.MainPage_Routes,
                Image = ResourceHelper.GetIconUri("routes")
            };

            Favorites = new ContentButtonViewModel
            {
                Text = AppResources.MainPage_Favorites,
                Image = ResourceHelper.GetIconUri("favorites")
            };

            Search = new ContentButtonViewModel
            {
                Text = AppResources.MainPage_Search,
                Image = ResourceHelper.GetIconUri("search")
            };
        }
    }
}