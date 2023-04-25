using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppSupportTicketSys.Models;

public partial class TicketSysEntities : DbContext
{
    public TicketSysEntities()
    {
    }

    public TicketSysEntities(DbContextOptions<TicketSysEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("AccountId");
            entity.Property(e => e.FullName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(250)
                .IsUnicode(false);

        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.StatusId)
                .ValueGeneratedNever()
                .HasColumnName("StatusId");
            entity.Property(e => e.Display).HasColumnName("Status");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.ToTable("Ticket");

            entity.Property(e => e.TicketId)
                .ValueGeneratedNever()
                .HasColumnName("TicketId");
            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.ClientName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClientEmail)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Employee).WithMany(p => p.TicketEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Ticket_Account1");

            entity.HasOne(d => d.Status).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ticket_Status");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
