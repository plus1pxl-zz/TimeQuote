namespace TimeQuote.Data.Models
{
    using System.Collections.Generic;

    using TimeQuote.Data.Common.Models;

    public class Organization : BaseModel<int>
    {
        public string Name { get; set; }

        public virtual ICollection<Client> Clients { get; set; } = new HashSet<Client>();

        public virtual ICollection<Project> Projects { get; set; } = new HashSet<Project>();
    }
}
