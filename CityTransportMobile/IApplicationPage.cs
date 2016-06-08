using CityTransportMobile.ViewModels.PageViewModels;

namespace CityTransportMobile
{
    public interface IApplicationPage<TViewModel> where TViewModel : BasePageViewModel
    {
        TViewModel PageViewModel { get; set; }

        void Binding(TViewModel viewModel);
    }
}