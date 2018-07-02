﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Model.Comercial.Products;
using Model.Common;
using Model.Configuration;
using Model.Solution.Location;
using System;

namespace TormundAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20180509063804_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Comercial.Branches.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Model.Comercial.Companies.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("WebSite");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Model.Comercial.Customer.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<DateTime>("BornDate");

                    b.Property<int?>("BranchId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Name");

                    b.Property<int?>("PreferenceId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("BranchId");

                    b.HasIndex("PreferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Model.Comercial.Employees.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<DateTime>("BornDate");

                    b.Property<int?>("BranchId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("Name");

                    b.Property<int?>("PreferenceId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("BranchId");

                    b.HasIndex("PreferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Model.Comercial.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int?>("SupplierId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Model.Comercial.Services.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Model.Comercial.Suppliers.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Model.Common.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerId");

                    b.Property<int?>("EmployeeId");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Number");

                    b.Property<int?>("SupplierId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("Model.Common.Preferences.Preference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("Model.Solution.Geographic.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name");

                    b.Property<int?>("StateId");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Model.Solution.Geographic.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Model.Solution.Geographic.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CountryId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Model.Solution.Location.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressType");

                    b.Property<int?>("CityId");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Number");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Model.Solution.Location.Neighborhood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CityId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Neighborhoods");
                });

            modelBuilder.Entity("Model.Solution.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("TokenFacebook");

                    b.Property<string>("TokenGoogle");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Model.Comercial.Branches.Branch", b =>
                {
                    b.HasOne("Model.Comercial.Companies.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("Model.Comercial.Customer.Customer", b =>
                {
                    b.HasOne("Model.Solution.Location.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Model.Comercial.Branches.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("Model.Common.Preferences.Preference", "Preference")
                        .WithMany()
                        .HasForeignKey("PreferenceId");

                    b.HasOne("Model.Solution.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Model.Comercial.Employees.Employee", b =>
                {
                    b.HasOne("Model.Solution.Location.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Model.Comercial.Branches.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("Model.Common.Preferences.Preference", "Preference")
                        .WithMany()
                        .HasForeignKey("PreferenceId");

                    b.HasOne("Model.Solution.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Model.Comercial.Products.Product", b =>
                {
                    b.HasOne("Model.Comercial.Suppliers.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("Model.Comercial.Suppliers.Supplier", b =>
                {
                    b.HasOne("Model.Solution.Location.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("Model.Common.Phone", b =>
                {
                    b.HasOne("Model.Comercial.Customer.Customer")
                        .WithMany("Phones")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Model.Comercial.Employees.Employee")
                        .WithMany("Phones")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Model.Comercial.Suppliers.Supplier")
                        .WithMany("Phones")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("Model.Solution.Geographic.City", b =>
                {
                    b.HasOne("Model.Solution.Geographic.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("Model.Solution.Geographic.State", b =>
                {
                    b.HasOne("Model.Solution.Geographic.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("Model.Solution.Location.Address", b =>
                {
                    b.HasOne("Model.Solution.Geographic.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("Model.Solution.Location.Neighborhood", b =>
                {
                    b.HasOne("Model.Solution.Geographic.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });
#pragma warning restore 612, 618
        }
    }
}