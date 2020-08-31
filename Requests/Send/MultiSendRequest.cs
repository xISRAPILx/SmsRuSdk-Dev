using IsrapilAkhmedov.SmsRuSdk.Requests.Attributes;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace IsrapilAkhmedov.SmsRuSdk.Requests.Send
{
    class MultiSendRequest : AbstractSendRequest
    {
        [RequestProperty(Ignore = true)]
        public Dictionary<string, string> Messages { get; set; }

        public MultiSendRequest(Dictionary<string, string> messages)
        {
            Messages = messages;
        }

        public override void BeforeBind(NameValueCollection nameValueCollection)
        {
            foreach (KeyValuePair<string, string> entry in Messages)
            {
                nameValueCollection["to[" + entry.Key + "]"] = entry.Value;
            }
        }
    }
}
