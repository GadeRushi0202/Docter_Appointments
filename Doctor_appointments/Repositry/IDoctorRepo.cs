using Doctor_appointments.Models;

namespace Doctor_appointments.Repositry
{
    public interface IDoctorRepo
    {
        IEnumerable<Doctor> GetAllDoctor();
        Doctor GetDoctorById(int id);
        int AddDoctor(Doctor doctor);
        int UpdateDoctor(Doctor doctor);
        int DeleteDoctor(int id);
    }
}
