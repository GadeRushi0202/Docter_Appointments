using Doctor_appointments.Models;

namespace Doctor_appointments.Services
{
    public interface IDoctorServices
    {
        IEnumerable<Doctor> GetAllDoctor();
        Doctor GetDoctorById(int id);
        int AddDoctor(Doctor doctor);
        int UpdateDoctor(Doctor doctor);
        int DeleteDoctor(int id);
    }
}
