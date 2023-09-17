using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace CocoaLib.DbModels;


public partial class QbotContext : DbContext
{
    string connectionString = ConfigurationManager.ConnectionStrings["npgsqlConnectionString"].ConnectionString;

    public QbotContext()
    {
    }

    public QbotContext(DbContextOptions<QbotContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Loginrelation> Loginrelations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Loginrelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("loginrelation_pkey");

            entity.ToTable("loginrelation");

            entity.HasIndex(e => e.Email, "loginrelation_email_key").IsUnique();

            entity.HasIndex(e => e.Username, "loginrelation_username_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
