using GhasedakSms.Core.Enum;

namespace GhasedakSms.Core.Dto
{
    public class SendBulkResponse
    {
        public int Cost { get; set; }
        public string LineNumber { get; set; }
        public string ClientReferenceId { get; set; }
        public List<ReceptionInfo> Receptors { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }

        public class ReceptionInfo
        {
            public string Receptor { get; set; }
            public string MessageId { get; set; }
        }
    }

}
