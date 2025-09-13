using System.ComponentModel.DataAnnotations;

namespace WorkforceScheduler.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Role { get; set; } = string.Empty;
        public int MaxHoursPerWeek { get; set; }
        public bool IsActive { get; set; }
        public int? ShiftId { get; set; }  // FK to Shifts.Id
        public Shifts? Shift { get; set; }  // Navigation to principal
    }
}