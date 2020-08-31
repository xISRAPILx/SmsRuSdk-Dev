using System;

namespace IsrapilAkhmedov.SmsRuSdk.Requests.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    class RequestProperty : System.Attribute
    {
        public string Name { get; set; }
        public bool Ignore { get; set; }

        public RequestProperty()
        {

        }

        public RequestProperty(string name)
        {
            Name = name;
        }

        public RequestProperty(string name, bool ignore) : this(name)
        {
            Ignore = ignore;
        }
    }
}
