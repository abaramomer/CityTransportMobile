using System;
using System.Collections.Generic;
using CityTransportMobile.Helpers;
using CityTransportMobile.Resources;
using Shared.Models.ModelTypes;

namespace CityTransportMobile.ViewModels.PageViewModels
{
    public class TransportTypesViewModel : BasePageViewModel
    {
        private const string ResourceTransportPrefix = "TransportType_";

        public List<ContentButtonViewModel> TransportTypes { get; set; }

        public TransportTypesViewModel()
        {
            TransportTypes = new List<ContentButtonViewModel>();
            Title = AppResources.MainPage_Routes;

            FillTypes();
            
        }

        private void FillTypes()
        {
            var types = ResourceHelper.GetResources(d => d.Key.ToString().StartsWith(ResourceTransportPrefix));

            foreach (var type in types)
            {
                TransportType transportType;
                var typeName = type.Key.ToString().Replace(ResourceTransportPrefix, "");

                if (Enum.TryParse(typeName, out transportType))
                {
                    TransportTypes.Add(new ContentButtonViewModel()
                    {
                        Id = (int)transportType,
                        Text = type.Value.ToString(),
                        Image = ResourceHelper.GetIconUri(typeName.ToLower())
                    });
                }
            }
        }
    }
}