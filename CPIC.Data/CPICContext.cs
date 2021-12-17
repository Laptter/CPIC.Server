using CPIC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace CPIC.Data
{
    public class CPICContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Server=(192.168.174.188)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
        }

        public DbSet<User> Users;
        public DbSet<Company> Companys;
        public DbSet<Entrance> Entrances;
        public DbSet<Record> Records;
        public DbSet<GatePassRecord> GatePassRecords;
        public DbSet<Led> Leds;
    }
}