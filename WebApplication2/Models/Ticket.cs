using System;
using System.Collections.Generic;

namespace AppSupportTicketSys.Models;

public partial class Ticket
{
    public Ticket(){}
    public int TicketId { get; set; }

    public string Description { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int StatusId { get; set; }

    public int? EmployeeId { get; set; }

    public int ClientName { get; set; }

    public int ClientEmail { get; set; }

    public virtual Account? Employee { get; set; }

    public virtual Status Status { get; set; } = null!;

}
