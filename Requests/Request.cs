using IsrapilAkhmedov.SmsRuSdk.Requests.Attributes;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;

namespace IsrapilAkhmedov.SmsRuSdk.Requests
{
    abstract class Request : IRequestPart
    {
        private static Dictionary<string, ParamProperty[]> _propertiesCache;

        public virtual void BeforeBind(NameValueCollection nameValueCollection)
        {

        }

        public void Bind(NameValueCollection nameValueCollection)
        {
            BeforeBind(nameValueCollection);

            if (_propertiesCache == null)
                _propertiesCache = new Dictionary<string, ParamProperty[]>();

            var type = GetType();

            ParamProperty[] paramProperties;
            if (_propertiesCache.TryGetValue(type.FullName, out paramProperties))
            {
                foreach(ParamProperty paramProperty in paramProperties)
                {
                    var value = type.GetProperty(paramProperty.PropertyName).GetValue(this);
                    if (value != null)
                    {
                        nameValueCollection[paramProperty.ParamName] = value.ToString();
                    }
                }
            }
            else
            {
                var properties = type.GetProperties();
                paramProperties = new ParamProperty[properties.Length];

                int i = 0;
                foreach (var property in properties)
                {
                    var paramPropety = new ParamProperty
                    {
                        ParamName = property.Name,
                        PropertyName = property.Name
                    };

                    var requestProperty = (RequestProperty) property.GetCustomAttribute(typeof(RequestProperty));
                    if (requestProperty != null)
                    {
                        if (requestProperty.Ignore)
                            continue;

                        paramPropety.ParamName = requestProperty.Name;
                    }

                    paramProperties[i++] = paramPropety;

                    var value = property.GetValue(this);
                    if (value != null)
                    {
                        nameValueCollection[paramPropety.ParamName] = value.ToString();
                    }
                }

                _propertiesCache.Add(type.FullName, paramProperties);
            }
        }

        internal class ParamProperty
        {
            public string PropertyName { get; set; }
            public string ParamName { get; set; }
        }
    }
}
