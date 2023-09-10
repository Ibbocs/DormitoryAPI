using DormitoryApi.Application.Entities.Autho;
using DormitoryApi.Application.Entities.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Context
{
    public class DormitoryDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public DormitoryDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Floor> Floors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var guidAdmin = Guid.NewGuid().ToString();
            var guidUser = Guid.NewGuid().ToString();
            var guidAdminCreat = Guid.NewGuid().ToString();
            // Role Seed Data
            builder.Entity<AppRole>().HasData(
                new AppRole { Id = guidAdmin, Name = "Admin", NormalizedName = "ADMIN" },
                new AppRole { Id = guidUser, Name = "User", NormalizedName = "USER" }
            );

            // User Seed Data
            var hasher = new PasswordHasher<AppUser>();

            var user = new AppUser
            {
                Id = guidAdminCreat,
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "default",
                LastName = "default",
                BirthDate = DateTime.UtcNow,
                SecurityStamp = Guid.NewGuid().ToString(),
                //ConcurrencyStamp = Guid.NewGuid().ToString(),
                LockoutEnabled = true
            };

            user.PasswordHash = hasher.HashPassword(user, "Admin!23");

            builder.Entity<AppUser>().HasData(user);

            // User - Role Relationship Seed Data
            builder.Entity<AppUserRole>().HasData(
                new AppUserRole { UserId = guidAdminCreat, RoleId = guidAdmin } // Admin user is assigned the Admin role
            );



            builder.Entity<Room>()
                .HasOne<Floor>(r=> r.Floor)
                .WithMany(f=>f.Rooms)
                .HasForeignKey(r=>r.FloorId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Entity<Student>()
                .HasOne<Room>(s=> s.Room)
                .WithMany(r=>r.Students)
                .HasForeignKey(s=>s.RoomID)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }

    
}
