﻿using IRunes.App.Models;
using Microsoft.EntityFrameworkCore;


namespace IRunes.App.Data
{
    public class IRunesContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = @"Server=.\SQLEXPRESS; Databse=IRunnerDB; Trusted_Connection=True; Integrated Security=True;";
            optionsBuilder.UseSqlServer(conn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
