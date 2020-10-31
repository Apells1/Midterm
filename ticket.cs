using System;
using System.Collections.Generic;


//push come to shove add functionality to add tickets to a list to display them.
namespace ticketClass
{
    public abstract class ticket
    {
        // public properties
        public UInt64 TicketId { get; set; }
        public string summary { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
        public string submitter { get; set; }
        public string assigned { get; set; }
        public string watching { get; set; }




        public ticket()
        {

        }


        public virtual string Display()
        {
            return $"Id: {TicketId}\nsummary: {summary}\nstatus: {status}\npriority: {priority}\nsubmitter: {submitter}\nassigned: {assigned}\nwatching: {watching}";
        }
    }

    public class bugTicket : ticket
    {
        public string severity { get; set; }


        public override string Display()
        {
            return $"--Bug ticket--\nId: {TicketId}\nsummary: {summary}\nstatus: {status}\npriority: {priority}\nsubmitter: {submitter}\nassigned: {assigned}\nwatching: {watching}\nseverity:{severity}";
        }
    }
    public class enhanceTicket : ticket
    {
        public string software { get; set; }
        public string cost { get; set; }
        public string reason { get; set; }

        public string estimate { get; set; }


        public override string Display()
        {
            return $"--Enhancement ticket--\nId: {TicketId}\nsummary: {summary}\nstatus: {status}\npriority: {priority}\nsubmitter: {submitter}\nassigned: {assigned}\nwatching: {watching}\nsoftware: {software}\ncost: {cost}\nreason: {reason}\nestimate: {estimate}\n";
        }
    }
    public class taskTicket : ticket
    {
        public string projectName { get; set; }
        public string dueDate { get; set; }


        public override string Display()
        {
            return $"--Task ticket--\nId: {TicketId}\nsummary: {summary}\nstatus: {status}\npriority: {priority}\nsubmitter: {submitter}\nassigned: {assigned}\nwatching: {watching}\nproject name: {projectName}\ndue date: {dueDate}\n";
        }
    }
}
