using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using klovecore2.Models;

namespace klovecore2.Models
{
    public class MyDatabaseContext : DbContext
    {
       
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<klovecore2.Models.Employee> Employee { get; set; }

        public DbSet<klovecore2.Models.Department> Department { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Department>().ToTable("Department");


        }


        }
    }
