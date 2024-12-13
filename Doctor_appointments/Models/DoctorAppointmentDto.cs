using System.ComponentModel.DataAnnotations;

namespace Doctor_appointments.Models
{
    public class DoctorAppointmentDto
    {
        public int Id { get; set; } // Doctor's ID
        public string? Name { get; set; } // Doctor's Name


        public decimal FeesPerHour { get; set; } // Fees per hour (decimal for precision)

        public string? MobileNumber { get; set; } // Mobile number with validation
        public int Experience { get; set; } // Years of experience

        public string? Speciality { get; set; } // Doctor's speciality

        public string? Code { get; set; } // Unique code for the doctor

        public int AppointmentId { get; set; } // Appointment ID

        public decimal RemainingFees { get; set; } // Remaining fees for the appointment

        public double TotalAppointmentTime { get; set; }
    }
}
