using Doctor_appointments.Models;
using Doctor_appointments.Repositry;

namespace Doctor_appointments.Services
{
    public class AppointmentServices : IAppointmentServices
    {
        private readonly IAppointmentRepo repo;
        public AppointmentServices(IAppointmentRepo repo)
        {
            this.repo = repo;
        }
        public int AddAppointment(Appointment appointment)
        {
            return repo.AddAppointment(appointment);
        }

        public int DeleteAppointment(int id)
        {
            return repo.DeleteAppointment(id);
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return repo.GetAllAppointments();
        }

        public Appointment GetAppointmentById(int id)
        {
            return repo.GetAppointmentById(id);
        }

        public int UpdateAppointment(Appointment appointment)
        {
            return repo.UpdateAppointment(appointment);
        }
    }
}
