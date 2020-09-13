using System;
using System.Collections.Generic;

namespace FilingCabinet_Core
{
    class CardInformation
    {
        public CardInformation()
        {
        }

        public CardInformation(int inventoryNumber, DateTime receiptDate, string designation, string name, string comment, SortedDictionary<string, int> kitFormat, List<CardApplicability> cardApplicabilities, List<CardChangeAccounting> cardChangeAccountings, List<CardCopyAccounting> cardCopyAccountings, List<CardIssuanceOfCopies> cardIssuanceOfCopies)
        {
            InventoryNumber = inventoryNumber;
            ReceiptDate = receiptDate;
            Designation = designation;
            Name = name;
            Comment = comment;
            KitFormat = kitFormat;
            CardApplicabilities = cardApplicabilities;
            CardChangeAccountings = cardChangeAccountings;
            CardCopyAccountings = cardCopyAccountings;
            CardIssuanceOfCopies = cardIssuanceOfCopies;
        }

        public int InventoryNumber { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string Designation { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public SortedDictionary<string, int> KitFormat { get; set; }
        public List<CardApplicability> CardApplicabilities { get; set; }
        public List<CardChangeAccounting> CardChangeAccountings { get; set; }
        public List<CardCopyAccounting> CardCopyAccountings { get; set; }
        public List<CardIssuanceOfCopies> CardIssuanceOfCopies { get; set; }


    }
}
