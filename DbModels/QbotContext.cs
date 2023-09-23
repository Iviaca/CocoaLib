using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CocoaLib.DbModels;

public partial class QbotContext : DbContext
{
    public QbotContext()
    {
    }

    public QbotContext(DbContextOptions<QbotContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LoginWpfUsersInfo> LoginWpfUsersInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["npgsqlConnectionString"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoginWpfUsersInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("loginrelation_pkey");

            entity.ToTable("LoginWpfUsersInfo");

            entity.HasIndex(e => e.Email, "loginrelation_email_key").IsUnique();

            entity.HasIndex(e => e.Username, "loginrelation_username_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('loginrelation_id_seq'::regclass)")
                .HasColumnName("id");
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
