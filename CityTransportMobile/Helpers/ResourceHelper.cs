using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using CityTransportMobile.Resources;

namespace CityTransportMobile.Helpers
{
    public static class ResourceHelper
    {
        public static List<DictionaryEntry> GetResources(Predicate<DictionaryEntry> predicate)
        {
            var set = AppResources.ResourceManager.GetResourceSet(new CultureInfo("ru-RU"), true, true);
            var result = new List<DictionaryEntry>();

            foreach (DictionaryEntry entry in set)
            {
                if (predicate(entry))
                {
                    result.Add(entry);
                }
            }

            return result;
        }

        public static Uri GetIconUri(string iconName)
        {
            var viewModelRelativePath = @"../Assets/Icons";
            var format = "png";

            return new Uri(string.Format(@"{0}/{1}.{2}", viewModelRelativePath, iconName, format), UriKind.Relative);
        }        
    }
}