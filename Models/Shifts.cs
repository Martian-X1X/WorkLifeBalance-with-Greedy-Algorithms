using System.ComponentModel.DataAnnotations;

namespace WorkforceScheduler.Models
{
    public class Shifts
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public TimeSpan? StartTime { get; set; }
        [Required]
        public TimeSpan? EndTime { get; set; }
        public Employee? Employee { get; set; }  // Navigation to dependent (singular for one-to-one)
    }
}