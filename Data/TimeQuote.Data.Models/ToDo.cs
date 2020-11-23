namespace TimeQuote.Data.Models
{
    using TimeQuote.Data.Common.Models;

    public class ToDo : BaseDeletableModel<int>
    {
        public string Description { get; set; }

        public string ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public bool IsCompleted { get; set; }

        public double TimeSpent { get; set; }

        public string AssignedToUserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
