using System;
using TimeQuote.Data.Models.Enums;

namespace TimeQuote.Data.Models
{
    public class ProjectApplicationUser
    {
        public int Id { get; set; }

        public string ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public ProjectRole Role { get; set; }
    }
}
