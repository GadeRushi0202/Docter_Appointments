using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Doctor_appointments.Data;
using Doctor_appointments.Models;
using Doctor_appointments.Repositry;

namespace Task_Doctor.Repository
{
    public class AppointmentRepo : IAppointmentRepo
    {
        private readonly ApplicationDbContext db;

        public AppointmentRepo(ApplicationDbContext db)
        {
            this.db = db;
        }

        // Add a new appointment
        public int AddAppointment(Appointment appointment)
        {
            int res = 0;
            db.Appointments.Add(appointment);
            return db.SaveChanges();
        }

        // Delete an appointment by its ID
        public int DeleteAppointment(int id)
        {
            var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentId == id);
            if (appointment != null)
            {
                db.Appointments.Remove(appointment);
                return db.SaveChanges();
            }
            return 0;
        }

        // Get all appointments with doctor and patient details
        public IEnumerable<Appointment> GetAllAppointments()
        {
            return db.Appointments.Include(a => a.Doctor).ToList();
        }

        // Get an appointment by its ID
        public Appointment GetAppointmentById(int id)
        {
            return db.Appointments
             .Include(a => a.Doctor) // Include the Doctor entity
             .SingleOrDefault(a => a.AppointmentId == id);
        }

        // Update an existing appointment
        public int UpdateAppointment(Appointment appointment)
        {
            var res = db.Appointments
                                        .Include(a => a.Doctor) // Include related Doctor
                                        .FirstOrDefault(a => a.AppointmentId == appointment.AppointmentId);

            if (res != null)
            {
                res.PatientName = appointment.PatientName;
                res.DoctorId = appointment.DoctorId;
                res.Description = appointment.Description;
                res.AppointmentDate = appointment.AppointmentDate;
                res.StartTime = appointment.StartTime;
                res.EndTime = appointment.EndTime;
                res.TotalFees = appointment.TotalFees;
                res.PaidFees = appointment.PaidFees;

                return db.SaveChanges();
            }
            return 0;
        }

    }
}
