using IsrapilAkhmedov.SmsRuSdk.Requests.Credential;

namespace IsrapilAkhmedov.SmsRuSdk
{
    public class SmsRuClient
    {
        public const string BASE_URL = "https://sms.ru/";

        private readonly ICredential _credential;

        public SmsRuClient(string login, string password)
        {
            _credential = new Credential(login, password);
        }

        public SmsRuClient(string apiId)
        {
            _credential = new ApiIdCredential(apiId);
        }
    }
}
