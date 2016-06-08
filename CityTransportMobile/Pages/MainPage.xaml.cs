using System;
using CityTransportMobile.ViewModels.PageViewModels;
using Microsoft.Phone.Controls;

namespace CityTransportMobile.Pages
{
    public partial class MainPage : PhoneApplicationPage, IApplicationPage<MainPageViewModel>
    {
        public MainPageViewModel PageViewModel { get; set; }

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            PageViewModel = new MainPageViewModel();

            Binding(PageViewModel);
        }

        public void Binding(MainPageViewModel viewModel)
        {
            RouteButton.DataContext = viewModel.Routes;
            FavoriteButton.DataContext = viewModel.Favorites;
            SearchButton.DataContext = viewModel.Search;
        }

        public void OnRouteClick(object sender, EventArgs eventArgs)
        {
            NavigationService.Navigate(new Uri("/Pages/TransportTypes.xaml", UriKind.Relative));
        }

        public void OnSearchClick(object sender, EventArgs eventArgs)
        {

        }

        public void OnFavoritesClick(object sender, EventArgs eventArgs)
        {
        }
    }
}