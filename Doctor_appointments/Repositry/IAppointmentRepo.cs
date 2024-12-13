using Doctor_appointments.Models;

namespace Doctor_appointments.Repositry
{
    public interface IAppointmentRepo
    {
        IEnumerable<Appointment> GetAllAppointments();
        Appointment GetAppointmentById(int id);
        int AddAppointment(Appointment appointment);
        int UpdateAppointment(Appointment appointment);
        int DeleteAppointment(int id);
    }
}
