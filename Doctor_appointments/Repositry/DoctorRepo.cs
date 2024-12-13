using Doctor_appointments.Data;
using Doctor_appointments.Models;

namespace Doctor_appointments.Repositry
{
    public class DoctorRepo : IDoctorRepo
    {
        private readonly ApplicationDbContext db;

        public DoctorRepo(ApplicationDbContext db)
        {
            this.db = db;
        }

        // Add a new doctor
        public int AddDoctor(Doctor doctor)
        {
            db.Doctors.Add(doctor);
            return db.SaveChanges();
        }

        // Delete a doctor by their ID
        public int DeleteDoctor(int id)
        {
            var doctor = db.Doctors.FirstOrDefault(d => d.DoctorId == id);
            if (doctor != null)
            {
                db.Doctors.Remove(doctor);
                return db.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Doctor> GetAllDoctor()
        {
            return db.Doctors.ToList();
        }

        // Get a doctor by their ID
        public Doctor GetDoctorById(int id)
        {
            return db.Doctors.SingleOrDefault(d => d.DoctorId == id);
        }

        // Update an existing doctor's information
        public int UpdateDoctor(Doctor doctor)
        {
            var existingDoctor = db.Doctors.FirstOrDefault(d => d.DoctorId == doctor.DoctorId);
            if (existingDoctor != null)
            {
                existingDoctor.Name = doctor.Name;
                existingDoctor.MobileNumber = doctor.MobileNumber;
                existingDoctor.Code = doctor.Code;
                existingDoctor.FeesPerHour = doctor.FeesPerHour;
                existingDoctor.Experience = doctor.Experience;
                existingDoctor.Speciality = doctor.Speciality;
                return db.SaveChanges();
            }
            return 0;
        }
    }
}
