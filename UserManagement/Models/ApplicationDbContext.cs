using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Entities;

namespace UserManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UserManagement;Trusted_Connection=True;");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }
        public DbSet<UserIdentityCard> UserIdentityCards { get; set; }
    }
}
