using System;
using System.Collections.Generic;

namespace AppSupportTicketSys.Models;

public partial class Account
{
    public Account()
    {
        TicketEmployees = new HashSet<Ticket>();
    }
    public int AccountId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public virtual ICollection<Ticket> TicketEmployees { get; set; }

}
