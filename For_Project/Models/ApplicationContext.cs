using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace For_Project.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<X> xes { get; set; } //таблица БД

        public ApplicationContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=1111;database=for_project;"); //строка подключения к БД в MySQL
        }
    }
}
