using GraduationDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace GraduationDatabase.Data
{
    public class WebDbContext : DbContext 
    {

        public WebDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Thesis> Theses { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<SignIn> tbl_SignUps { get; set; }

        public DbSet<SignIn> tbl_signins { get; set; }

       







    }
}

