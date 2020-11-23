namespace TimeQuote.Data.Models
{
    using System;
    using System.Collections.Generic;

    using TimeQuote.Data.Common.Models;

    public class Client : BaseDeletableModel<string>
    {
        public Client()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public ICollection<Project> Projects { get; set; } = new HashSet<Project>();
    }
}
