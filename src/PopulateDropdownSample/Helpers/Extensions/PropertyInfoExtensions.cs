using System.Linq;
using System.Reflection;

namespace PopulateDropdownSample.Helpers.Extensions
{
    public static class PropertyInfoExtensions
    {
        public static TAttribute GetAttribute<TAttribute>(this PropertyInfo property)
        {
            return property.GetCustomAttributes(typeof(TAttribute), false).Cast<TAttribute>().FirstOrDefault();
        }
    }
}