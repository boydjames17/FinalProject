using System;
using System.Collections.Generic;

namespace AppSupportTicketSys.Models;

public partial class Status
{

    public Status()
    {
        Tickets = new HashSet<Ticket>();
    }
    public int StatusId { get; set; }

    public bool Display { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; }
}
