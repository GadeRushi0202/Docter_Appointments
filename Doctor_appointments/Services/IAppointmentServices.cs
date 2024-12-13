using Doctor_appointments.Models;

namespace Doctor_appointments.Services
{
    public interface IAppointmentServices
    {
        IEnumerable<Appointment> GetAllAppointments();
        Appointment GetAppointmentById(int id);
        int AddAppointment(Appointment appointment);
        int UpdateAppointment(Appointment appointment);
        int DeleteAppointment(int id);
    }
}
