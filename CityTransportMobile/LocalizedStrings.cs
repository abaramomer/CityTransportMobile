using CityTransportMobile.Resources;

namespace CityTransportMobile
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources T { get { return _localizedResources; } }
    }
}