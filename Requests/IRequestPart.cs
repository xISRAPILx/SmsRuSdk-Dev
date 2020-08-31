using System.Collections.Specialized;

namespace IsrapilAkhmedov.SmsRuSdk.Requests
{
    interface IRequestPart
    {
        void Bind(NameValueCollection nameValueCollection);
    }
}
