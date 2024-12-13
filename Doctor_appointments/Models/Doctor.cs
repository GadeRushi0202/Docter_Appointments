using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Doctor_appointments.Models
{
    [Table("Mst_Doctors")]
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal FeesPerHour { get; set; }

        [Required]
        [Phone]
        [StringLength(20)]
        public string? MobileNumber { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public string? Speciality { get; set; }

        [Required]
        public string? Code { get; set; }
    }
}

