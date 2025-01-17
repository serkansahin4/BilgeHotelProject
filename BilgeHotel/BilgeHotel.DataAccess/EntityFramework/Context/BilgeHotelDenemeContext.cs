﻿using BilgeHotel.DataAccess.EntityFramework.Context.ModelBuilderExtensions;
using BilgeHotel.DataAccess.EntityFramework.Maps;
using BilgeHotel.DataAccess.EntityFramework.Maps.Concrete;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.DataAccess.EntityFramework.Context
{
    public class BilgeHotelDenemeContext : IdentityDbContext<Employee, Role, int>
    {
        public BilgeHotelDenemeContext(DbContextOptions<BilgeHotelDenemeContext> db) : base(db)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //ComplexType
            modelBuilder.ApplyConfiguration(new ReservationDetailMap());
            modelBuilder.ApplyConfiguration(new ReservationOutHotelExtraMap());
            modelBuilder.ApplyConfiguration(new RoomBedMap());
            modelBuilder.ApplyConfiguration(new RoomTypeExtraMap());

            modelBuilder.ApplyConfiguration(new EmployeeJobMap());


            //Concrete
            modelBuilder.ApplyConfiguration(new BedMap());
            modelBuilder.ApplyConfiguration(new RoomMap());
            modelBuilder.ApplyConfiguration(new ExtraMap());
            modelBuilder.ApplyConfiguration(new RoomTypeMap());
            modelBuilder.ApplyConfiguration(new RoomViewMap());
            modelBuilder.ApplyConfiguration(new PackageMap());
            modelBuilder.ApplyConfiguration(new ReservationMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new HotelExtraMap());
            modelBuilder.ApplyConfiguration(new DepartmentMap());

            modelBuilder.ApplyConfiguration(new ImageMap());
            modelBuilder.ApplyConfiguration(new CardMap());


            modelBuilder.ApplyConfiguration(new ShiftMap());



            modelBuilder.ApplyConfiguration(new JobMap());
            modelBuilder.ApplyConfiguration(new ShiftTimeMap());


            modelBuilder.ApplyConfiguration(new DayMap());

            modelBuilder.ApplyConfiguration(new EmployeeMap());

            
            modelBuilder.Seed();


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Shift> Shifts { get; set; }

        public DbSet<Day> Days { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<ShiftTime> ShiftTimes { get; set; }

        public DbSet<EmployeeJob> EmployeeJobs { get; set; }




        public DbSet<Card> Cards { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<HotelExtra> HotelExtras { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomSituation> RoomSituations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomView> RoomViews { get; set; }

        public DbSet<Image> Images { get; set; }


        public DbSet<ReservationDetail> ReservationDetails { get; set; }
        public DbSet<ReservationOutHotelExtra> ReservationOutHotelExtras { get; set; }
        public DbSet<RoomBed> RoomBeds { get; set; }
        public DbSet<RoomTypeExtra> RoomTypeExtras { get; set; }



    }
}
