using Doctor_appointments.Models;
using Microsoft.EntityFrameworkCore;

namespace Doctor_appointments.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op) { }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
