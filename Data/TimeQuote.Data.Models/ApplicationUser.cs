// ReSharper disable VirtualMemberCallInConstructor
namespace TimeQuote.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;
    using TimeQuote.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        public string EmailAddress { get; set; }

        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }

        public int PaymentId { get; set; }

        public virtual Payment Payment { get; set; }

        public int LimitId { get; set; }

        public virtual Limit Limit { get; set; }

        public string ProjectId { get; set; }

        public ICollection<ProjectApplicationUser> ProjectApplicationUsers { get; set; } = new HashSet<ProjectApplicationUser>();

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
