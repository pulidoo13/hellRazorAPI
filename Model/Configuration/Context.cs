using Microsoft.EntityFrameworkCore;
using Model.Comercial;
using Model.Comercial.Branches;
using Model.Comercial.Companies;
using Model.Comercial.Customers;
using Model.Comercial.Employees;
using Model.Comercial.Products;
using Model.Comercial.Services;
using Model.Comercial.Suppliers;
using Model.Common;
using Model.Common.Preferences;
using Model.Dates;
using Model.Solution.Geographic;
using Model.Solution.Location;
using Model.Solution.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Configuration
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
           
        }



        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Date> Dates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Date>()
                .HasOne(p => p.Customer)
                .WithMany(b => b.Dates);
        }
        public void Connect()
        {
            // var ordenes = Db.Ordenes.ToList();
        }
    }
}
