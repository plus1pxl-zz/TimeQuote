namespace TimeQuote.Data.Models
{
    using System.Collections.Generic;

    using TimeQuote.Data.Common.Models;

    public class Limit : BaseDeletableModel<int>
    {
        public double WeeklyLimit { get; set; }

        public double DailyLimit { get; set; }

        public bool AllowedToWorkMonday { get; set; }

        public bool AllowedToWorkTuesday { get; set; }

        public bool AllowedToWorkWednesday { get; set; }

        public bool AllowedToWorkThursday { get; set; }

        public bool AllowedToWorkFriday { get; set; }

        public bool AllowedToWorkSaturday { get; set; }

        public bool AllowedToWorkSunday { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
