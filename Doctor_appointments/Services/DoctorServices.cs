using Doctor_appointments.Models;
using Doctor_appointments.Repositry;

namespace Doctor_appointments.Services
{
    public class DoctorServices : IDoctorServices
    {
        private readonly IDoctorRepo repo;
        public DoctorServices(IDoctorRepo repo) 
        {
            this.repo = repo;
        }
        public int AddDoctor(Doctor doctor)
        {
            return repo.AddDoctor(doctor);  
        }

        public int DeleteDoctor(int id)
        {
            return repo.DeleteDoctor(id);
        }

        public IEnumerable<Doctor> GetAllDoctor()
        {
            return repo.GetAllDoctor();
        }

        public Doctor GetDoctorById(int id)
        {
            return repo.GetDoctorById(id);
        }

        public int UpdateDoctor(Doctor doctor)
        {
            return repo.UpdateDoctor(doctor);
        }
    }
}
