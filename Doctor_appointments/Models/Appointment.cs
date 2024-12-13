using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doctor_appointments.Models
{
    [Table("Mst_Appointments")]
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public string? PatientName { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalFees { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Paid Fees cannot exceed Total Fees.")]
        public decimal PaidFees { get; set; }

        [NotMapped]
        public decimal RemainingFees => TotalFees - PaidFees;

        [NotMapped]
        public double TotalAppointmentTime => (EndTime - StartTime).TotalHours;
    }
}

