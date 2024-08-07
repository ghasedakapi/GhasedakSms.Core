﻿using GhasedakSms.Core.Enum;

namespace GhasedakSms.Core.Dto
{
    public class SendPairToPairResponse
    {
        public List<PairData> Items { get; set; }

        public class PairData
        {
            public string LineNumber { get; set; }
            public string Receptor { get; set; }
            public string MessageId { get; set; }
            public int Cost { get; set; }
            public string ClientReferenceId { get; set; }
            public DateTime SendDate { get; set; }
            public string Message { get; set; }
        }
    }

}
