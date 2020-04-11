using System;
using _11_EntityFrameworkMysql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _11_EntityFrameworkMysql.Business
{
    public partial class employeesContext : DbContext
    {
        public employeesContext()
        {
        }

        public employeesContext(DbContextOptions<employeesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DeptEmp> DeptEmp { get; set; }
        public virtual DbSet<DeptManager> DeptManager { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Salaries> Salaries { get; set; }
        public virtual DbSet<Titles> Titles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=root;database=employees");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DeptNo);

                entity.ToTable("departments", "employees");

                entity.HasIndex(e => e.DeptName)
                    .HasName("dept_name")
                    .IsUnique();

                entity.Property(e => e.DeptNo)
                    .HasColumnName("dept_no")
                    .HasColumnType("char(4)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasColumnName("dept_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeptEmp>(entity =>
            {
                entity.HasKey(e => new { e.EmpNo, e.DeptNo });

                entity.ToTable("dept_emp", "employees");

                entity.HasIndex(e => e.DeptNo)
                    .HasName("dept_no");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeptNo)
                    .HasColumnName("dept_no")
                    .HasColumnType("char(4)");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("date");

                entity.Property(e => e.ToDate)
                    .HasColumnName("to_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.DeptNoNavigation)
                    .WithMany(p => p.DeptEmp)
                    .HasForeignKey(d => d.DeptNo)
                    .HasConstraintName("dept_emp_ibfk_2");

                entity.HasOne(d => d.EmpNoNavigation)
                    .WithMany(p => p.DeptEmp)
                    .HasForeignKey(d => d.EmpNo)
                    .HasConstraintName("dept_emp_ibfk_1");
            });

            modelBuilder.Entity<DeptManager>(entity =>
            {
                entity.HasKey(e => new { e.EmpNo, e.DeptNo });

                entity.ToTable("dept_manager", "employees");

                entity.HasIndex(e => e.DeptNo)
                    .HasName("dept_no");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeptNo)
                    .HasColumnName("dept_no")
                    .HasColumnType("char(4)");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("date");

                entity.Property(e => e.ToDate)
                    .HasColumnName("to_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.DeptNoNavigation)
                    .WithMany(p => p.DeptManager)
                    .HasForeignKey(d => d.DeptNo)
                    .HasConstraintName("dept_manager_ibfk_2");

                entity.HasOne(d => d.EmpNoNavigation)
                    .WithMany(p => p.DeptManager)
                    .HasForeignKey(d => d.EmpNo)
                    .HasConstraintName("dept_manager_ibfk_1");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmpNo);

                entity.ToTable("employees", "employees");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasColumnType("enum('M','F')");

                entity.Property(e => e.HireDate)
                    .HasColumnName("hire_date")
                    .HasColumnType("date");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Salaries>(entity =>
            {
                entity.HasKey(e => new { e.EmpNo, e.FromDate });

                entity.ToTable("salaries", "employees");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("date");

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToDate)
                    .HasColumnName("to_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.EmpNoNavigation)
                    .WithMany(p => p.Salaries)
                    .HasForeignKey(d => d.EmpNo)
                    .HasConstraintName("salaries_ibfk_1");
            });

            modelBuilder.Entity<Titles>(entity =>
            {
                entity.HasKey(e => new { e.EmpNo, e.Title, e.FromDate });

                entity.ToTable("titles", "employees");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("date");

                entity.Property(e => e.ToDate)
                    .HasColumnName("to_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.EmpNoNavigation)
                    .WithMany(p => p.Titles)
                    .HasForeignKey(d => d.EmpNo)
                    .HasConstraintName("titles_ibfk_1");
            });
        }
    }
}
