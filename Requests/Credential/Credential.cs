using System.Collections.Specialized;

namespace IsrapilAkhmedov.SmsRuSdk.Requests.Credential
{
    class Credential : ICredential
    {
        private readonly string _login;
        private readonly string _password;

        public Credential(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public NameValueCollection Bind(NameValueCollection nameValueCollection)
        {
            nameValueCollection["login"] = _login;
            nameValueCollection["password"] = _password;

            return nameValueCollection;
        }
    }
}
