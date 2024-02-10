using EMS.DAL;
using Microsoft.EntityFrameworkCore;

namespace EMS.Data
{
    public class DeptDbContext : DbContext
    {
        public DeptDbContext(DbContextOptions<DeptDbContext> options)
            : base(options)
        {
        }

        public DbSet<EMS.DAL.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<EMS.DAL.EmpProfile>? EmpProfile { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for DeptMaster
            modelBuilder.Entity<DeptMaster>().HasData(
                new DeptMaster { DeptCode = 1, DeptName = "Information Technology" },
                new DeptMaster { DeptCode = 2, DeptName = "Human Resources" },
                new DeptMaster { DeptCode = 3, DeptName = "Finance" },
                new DeptMaster { DeptCode = 4, DeptName = "Marketing" },
                new DeptMaster { DeptCode = 5, DeptName = "Sales" },
                new DeptMaster { DeptCode = 6, DeptName = "Customer Support" },
                new DeptMaster { DeptCode = 7, DeptName = "Research and Development" },
                new DeptMaster { DeptCode = 8, DeptName = "Supply Chain" },
                new DeptMaster { DeptCode = 9, DeptName = "Legal" },
                new DeptMaster { DeptCode = 10, DeptName = "Public Relations" }
            );

            // Assume each EmpProfile is associated with a DeptCode.
            // The DateOfBirth and other fields should be adjusted as per your requirements.
            modelBuilder.Entity<EmpProfile>().HasData(
                new EmpProfile { EmpCode = 1, EmpName = "John Doe", DateOfBirth = new DateTime(1990, 1, 1), Email = "john.doe@example.com", DeptCode = 1 },
                new EmpProfile { EmpCode = 2, EmpName = "Jane Smith", DateOfBirth = new DateTime(1991, 2, 1), Email = "jane.smith@example.com", DeptCode = 2 },
                new EmpProfile { EmpCode = 3, EmpName = "William Johnson", DateOfBirth = new DateTime(1992, 3, 1), Email = "william.johnson@example.com", DeptCode = 3 },
                new EmpProfile { EmpCode = 4, EmpName = "Patricia Williams", DateOfBirth = new DateTime(1993, 4, 1), Email = "patricia.williams@example.com", DeptCode = 4 },
                new EmpProfile { EmpCode = 5, EmpName = "Michael Brown", DateOfBirth = new DateTime(1994, 5, 1), Email = "michael.brown@example.com", DeptCode = 5 },
                new EmpProfile { EmpCode = 6, EmpName = "Linda Davis", DateOfBirth = new DateTime(1995, 6, 1), Email = "linda.davis@example.com", DeptCode = 6 },
                new EmpProfile { EmpCode = 7, EmpName = "Robert Miller", DateOfBirth = new DateTime(1996, 7, 1), Email = "robert.miller@example.com", DeptCode = 7 },
                new EmpProfile { EmpCode = 8, EmpName = "Elizabeth Wilson", DateOfBirth = new DateTime(1997, 8, 1), Email = "elizabeth.wilson@example.com", DeptCode = 8 },
                new EmpProfile { EmpCode = 9, EmpName = "James Moore", DateOfBirth = new DateTime(1998, 9, 1), Email = "james.moore@example.com", DeptCode = 9 },
                new EmpProfile { EmpCode = 10, EmpName = "Barbara Taylor", DateOfBirth = new DateTime(1999, 10, 1), Email = "barbara.taylor@example.com", DeptCode = 10 }
            );
        }
    }
}
