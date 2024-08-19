using EN_Framework__2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EN_Framework__2.Contexts
{
    internal class ITIDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Servver= LAPTOP-1LQO0EC5 ;Database = ITI ; Trusted_Connection = True ; Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent API
            modelBuilder.Entity<Student>(S =>
            {
                S.Property(S=>S.Address)
                .HasDefaultValue("Cairo");

            S.Property(S=>S.FName)
           .IsRequired(true)
           .HasColumnType("varchar");



            });

            modelBuilder.Entity<Course>(c =>
            {
                c.Property(c => c.C_Id)
                .UseIdentityColumn(10,10);

                c.Property(c => c.Name)
               .IsRequired(true)
               .HasColumnType("varchar");

                c.Property(c => c.Description)
                .HasColumnName("Description");



            });

            modelBuilder.Entity<Topic>(t =>
            {
                t.Property(t => t.Id)
                .UseIdentityColumn(1, 1);

                t.Property(t => t.Name)
               .IsRequired(true)
               .HasColumnType("varchar");

            });

            modelBuilder.Entity<Stud_Course>(sc =>
            {
                sc.Property(sc => sc.id)
                .UseIdentityColumn(1, 1);

            });

            modelBuilder.Entity<Instructor>(i =>
            {
                i.Property(i => i.Id)
                .UseIdentityColumn(1, 1);

                i.Property(i => i.Name)
               .IsRequired(true)
               .HasColumnType("varchar");



            });

            modelBuilder.Entity<Department>(d =>
            {
                d.Property(d => d.Id)
                .UseIdentityColumn(10, 10);

                d.Property(d => d.Name)
               .IsRequired(true)
               .HasColumnType("varchar");

                d.Property(d => d.Hiring_Date)
                .HasComputedColumnSql("GETDATE()");



            });

           










            #endregion




            base.OnModelCreating(modelBuilder);
        }

        #region By_Convention
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }

        //public DbSet<Course_Inst> course_Insts { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Instructor> Instructors { get; set; }
        //public DbSet<Stud_Course> Studs { get; set; }
        //public DbSet<Topic> Topic { get; set; } 
        #endregion
    }
}
