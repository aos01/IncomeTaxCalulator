using System.ComponentModel;
using System.Reflection;

namespace ITC.Helpers
{
    public class StringHelper
    {
        public static string GetObjectPropertiesAndValuesAsString(object obj)
        {
            string result = Environment.NewLine;
            foreach (var propertyInfo in obj.GetType().GetProperties())
            {
                var propertyName = GetAttributeDisplayName(propertyInfo);
                var propertyValue = propertyInfo.GetValue(obj);
                result += $"{propertyName} : {propertyValue} {Environment.NewLine}";
            }
            return result;
        }
        private static string GetAttributeDisplayName(PropertyInfo property)
        {
            var atts = property.GetCustomAttributes(
                typeof(DisplayNameAttribute), true);
            if (atts.Length == 0)
                return null;
            return (atts[0] as DisplayNameAttribute).DisplayName;
        }
    }
}
