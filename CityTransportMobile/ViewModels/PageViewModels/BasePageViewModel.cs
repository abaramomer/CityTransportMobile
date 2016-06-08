using CityTransportMobile.Resources;

namespace CityTransportMobile.ViewModels.PageViewModels
{
    public abstract class BasePageViewModel
    {
        public string ApplicationTitle { get; set; }
        
        public string Title { get; set; }

        protected BasePageViewModel()
        {
            ApplicationTitle = AppResources.ApplicationTitle;
        }
    }
}