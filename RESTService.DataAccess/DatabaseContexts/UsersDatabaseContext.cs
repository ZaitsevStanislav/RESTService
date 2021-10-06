using Microsoft.EntityFrameworkCore;
using RESTService.DataAccess.Models;
using System;

namespace RESTService.DataAccess.DatabaseContexts
{
    public class UsersDatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public string DbPath { get; private set; }

        public UsersDatabaseContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}blogging.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
