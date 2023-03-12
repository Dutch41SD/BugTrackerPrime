using System;
using System.ComponentModel;

namespace BugTrackerPrime.Models
{
    public class TicketComment
    {
        public int Id { get; set; }

        [DisplayName("Member Comment")]
        public string Comment { get; set; }

        //Created
        [DisplayName("Date")]
        public DateTimeOffset Created { get; set; }

        //TicketId
        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        //UserId
        [DisplayName("Team Member")]
        public string UserId { get; set; }


        //Navigation properties
        public virtual Ticket Ticket { get; set; }
        public virtual BTUser User { get; set; }
    }
}
