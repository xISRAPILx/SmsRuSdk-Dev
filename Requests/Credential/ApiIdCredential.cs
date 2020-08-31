using System.Collections.Specialized;

namespace IsrapilAkhmedov.SmsRuSdk.Requests.Credential
{
    class ApiIdCredential : ICredential
    {
        private readonly string _apiId;

        public ApiIdCredential(string apiId)
        {
            _apiId = apiId;
        }

        public NameValueCollection Bind(NameValueCollection nameValueCollection)
        {
            nameValueCollection["api_key"] = _apiId;

            return nameValueCollection;
        }
    }
}
