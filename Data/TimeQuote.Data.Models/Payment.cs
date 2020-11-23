namespace TimeQuote.Data.Models
{
    using System.Collections.Generic;

    using TimeQuote.Data.Common.Models;
    using TimeQuote.Data.Models.Enums;

    public class Payment : BaseDeletableModel<int>
    {
        public PaymentPeriod Period { get; set; }

        public PaymentType Type { get; set; }

        public double Rate { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
