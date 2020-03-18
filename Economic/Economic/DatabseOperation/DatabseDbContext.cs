using Economic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Economic.DatabseOperation
{
    public class DatabseDbContext:DbContext
    {
        public DbSet<Category> Categorys{get; set;}
        public DbSet<Company> Companys{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conncetionString = "Server=DESKTOP-53FK54F\\SQLEXPRESS; Database=EconomicDB;Integrated Security=true";
            optionsBuilder.UseSqlServer(conncetionString);
        }
    }
}
