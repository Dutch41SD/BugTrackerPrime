using System.Collections.Generic;
using System.ComponentModel;

namespace BugTrackerPrime.Models
{
    public class Company
    {
        // Primary Key
        public int Id { get; set; }

        [DisplayName("Company Name")]
        public string Name { get; set; }

        [DisplayName("Company Description")]
        public string Description { get; set; }

        //Navigation Properties
        public virtual ICollection<BTUser> Members { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        // Create a relationship to invite
    }
}
