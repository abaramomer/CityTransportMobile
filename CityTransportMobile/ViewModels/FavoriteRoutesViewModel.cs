using System.Collections.ObjectModel;
using Shared.Models;

namespace CityTransportMobile.ViewModels
{
    public class FavoriteRoutesViewModel
    {
        public ObservableCollection<RouteModel> Routes { get; set; }
    }
}