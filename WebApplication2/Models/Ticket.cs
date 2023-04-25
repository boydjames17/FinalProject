using System;
using System.Collections.Generic;

namespace AppSupportTicketSys.Models;

public partial class Ticket
{
    public Ticket()
    {
        Discussions = new HashSet<Discussion>();
        Photos = new HashSet<Photo>();
    }
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int StatusId { get; set; }

    public int CategoryId { get; set; }

    public int PeriodId { get; set; }

    public int? EmployeeId { get; set; }

    public int SupporterId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Discussion> Discussions { get; set; }

    public virtual Account? Employee { get; set; }

    public virtual Period Period { get; set; } = null!;

    public virtual ICollection<Photo> Photos { get; set; }

    public virtual Status Status { get; set; } = null!;

    public virtual Account Supporter { get; set; } = null!;
}
