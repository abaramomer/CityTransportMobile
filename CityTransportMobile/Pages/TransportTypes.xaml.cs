using System;
using System.Windows.Controls;
using CityTransportMobile.ViewModels.PageViewModels;
using Microsoft.Phone.Controls;

namespace CityTransportMobile.Pages
{
    public partial class TransportTypes : PhoneApplicationPage,  IApplicationPage<TransportTypesViewModel>
    {
        public TransportTypes()
        {
            InitializeComponent();
            PageViewModel = new TransportTypesViewModel();
            Binding(PageViewModel);
        }

        public TransportTypesViewModel PageViewModel { get; set; }

        public void Binding(TransportTypesViewModel viewModel)
        {
            DataContext = viewModel;
        }

        public void OnItemClick(object sender, EventArgs eventArgs)
        {
            var item = (ContentControl) sender;
            var number = (int)item.Tag;
        }
    }
}