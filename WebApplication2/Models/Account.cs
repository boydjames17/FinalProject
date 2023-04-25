using System;
using System.Collections.Generic;

namespace AppSupportTicketSys.Models;

public partial class Account
{
    public Account()
    {
        Discussions = new HashSet<Discussion>();
        TicketEmployees = new HashSet<Ticket>();
        TicketSupporters = new HashSet<Ticket>();
    }
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Roleid { get; set; }

    public virtual ICollection<Discussion> Discussions { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Ticket> TicketEmployees { get; set; }

    public virtual ICollection<Ticket> TicketSupporters { get; set; }
}
