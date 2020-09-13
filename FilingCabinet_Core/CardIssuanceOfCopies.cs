using System;

namespace FilingCabinet_Core
{
    class CardIssuanceOfCopies
    {
        public string Subscriber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int InstanceNumber { get; set; }
        public DateTime DateWrittenOff { get; set; }

        public CardIssuanceOfCopies(string subscriber, DateTime dateOfIssue, int instanceNumber, DateTime dateWrittenOff)
        {
            Subscriber = subscriber;
            DateOfIssue = dateOfIssue;
            InstanceNumber = instanceNumber;
            DateWrittenOff = dateWrittenOff;
        }
    }
}
