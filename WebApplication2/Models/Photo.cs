using System;
using System.Collections.Generic;

namespace AppSupportTicketSys.Models;

public partial class Photo
{
    
    public int Id { get; set; }

    public string? Name { get; set; }

    public int TicketId { get; set; }

    public virtual Ticket? Ticket { get; set; }
}
