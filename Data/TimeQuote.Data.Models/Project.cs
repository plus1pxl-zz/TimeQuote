namespace TimeQuote.Data.Models
{
    using System;
    using System.Collections.Generic;

    using TimeQuote.Data.Common.Models;

    public class Project : BaseDeletableModel<string>
    {
        public Project()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public bool IsBillable { get; set; }

        public string ClientId { get; set; }

        public virtual Client Client { get; set; }

        public ICollection<ProjectApplicationUser> ProjectApplicationUsers { get; set; } = new HashSet<ProjectApplicationUser>();
    }
}
