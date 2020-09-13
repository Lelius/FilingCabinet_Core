using System;

namespace FilingCabinet_Core
{
    class CardCopyAccounting
    {
        public int CopyNumber { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime DateOfWriteOff { get; set; }
        public DateTime ReplacmentDate { get; set; }

        public CardCopyAccounting(int copyNumber, DateTime receiptDate, DateTime dateOfWriteOff, DateTime replacmentDate)
        {
            CopyNumber = copyNumber;
            ReceiptDate = receiptDate;
            DateOfWriteOff = dateOfWriteOff;
            ReplacmentDate = replacmentDate;
        }
    }
}
