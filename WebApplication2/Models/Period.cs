﻿using System;
using System.Collections.Generic;

namespace AppSupportTicketSys.Models;

public partial class Period
{
    public Period()
    {
        Tickets = new HashSet<Ticket>();
    }
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Status { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; }
}