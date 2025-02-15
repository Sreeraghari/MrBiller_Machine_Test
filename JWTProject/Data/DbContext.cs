using JWTProject.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}