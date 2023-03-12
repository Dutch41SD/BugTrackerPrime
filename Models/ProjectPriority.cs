using System.ComponentModel;

namespace BugTrackerPrime.Models
{
    public class ProjectPriority
    {
        //Primary Key
        public int Id { get; set; }

        [DisplayName("Priority Name")]
        public string Name { get; set; }
    }
}
