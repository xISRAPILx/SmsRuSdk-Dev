using IsrapilAkhmedov.SmsRuSdk.Requests.Attributes;

namespace IsrapilAkhmedov.SmsRuSdk.Requests.Send
{
    class SendRequest : AbstractSendRequest
    {
        [RequestProperty("to")]
        public string To { get; set; }

        [RequestProperty("Message")]
        public string Message { get; set; }

        public SendRequest(string to, string message)
        {
            To = to;
            Message = message;
        }
    }
}
