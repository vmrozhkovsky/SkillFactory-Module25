﻿using Microsoft.EntityFrameworkCore;

namespace EF;

public class AppContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    
    public AppContext()
    {
        // Database.EnsureDeleted();
        // Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=EF;Trusted_Connection=True;TrustServerCertificate=true;");
    }
}