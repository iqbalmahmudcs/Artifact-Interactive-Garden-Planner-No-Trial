using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class TrainingDbContext : DbContext 
    {
        private readonly string _connection;

        public TrainingDbContext()
        {

        }
        
        public TrainingDbContext(string connection)
        {
            _connection = connection;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Course> Courses {  get; set; }
    }
}
