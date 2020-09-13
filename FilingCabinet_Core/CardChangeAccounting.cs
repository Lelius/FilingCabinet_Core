using System;

namespace FilingCabinet_Core
{
    class CardChangeAccounting
    {
        public string Change { get; set; }
        public int NotificationNumber { get; set; }
        public DateTime DateOfEntry { get; set; }

         public CardChangeAccounting(string change, int notificationNumber, DateTime dateOfEntry)
        {
            Change = change;
            NotificationNumber = notificationNumber;
            DateOfEntry = dateOfEntry;
        }
    }
}
