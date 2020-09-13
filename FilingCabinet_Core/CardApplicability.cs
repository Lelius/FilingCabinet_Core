using System;

namespace FilingCabinet_Core
{
    class CardApplicability
    {
        public DateTime IntrodutionDate { get; set; }
        public string Designation { get; set; }

        public CardApplicability()
        {

        }

        public CardApplicability(DateTime introdutionDate)
        {
            IntrodutionDate = introdutionDate;
            Designation = "unknow";
        }

        public CardApplicability(DateTime introdutionDate, string designation)
        {
            IntrodutionDate = introdutionDate;
            Designation = designation;
        }
    }
}
