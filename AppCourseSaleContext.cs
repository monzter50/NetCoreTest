using System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace NetCore.Data
{
    public class AppCourseSaleContext:DbContext
    {
        public DbSet<Course> Course { get; set; }
        private const string connectionMySql = @"Server=localhost;database=;uid=;pwd=;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseMySql(connectionMySql);
        

    }
}
