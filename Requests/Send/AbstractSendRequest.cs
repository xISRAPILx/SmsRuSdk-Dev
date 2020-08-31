using IsrapilAkhmedov.SmsRuSdk.Requests.Attributes;

namespace IsrapilAkhmedov.SmsRuSdk.Requests.Send
{
    abstract class AbstractSendRequest : Request
    {
        [RequestProperty("from")]
        public string From { get; set; }

        [RequestProperty("ip")]
        public string Ip { get; set; }

        [RequestProperty("time")]
        public long? Time { get; set; }

        [RequestProperty("ttl")]
        public short? TimeToLive { get; set; }

        [RequestProperty("daytime")]
        public bool? DayTime { get; set; }

        [RequestProperty("translit")]
        public bool? Translit { get; set; }

        [RequestProperty("test")]
        public bool? Test { get; set; }

        [RequestProperty("partner_id")]
        public long? PartnerId { get; set; }
    }
}
