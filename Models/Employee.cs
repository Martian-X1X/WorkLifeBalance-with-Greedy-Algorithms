namespace WorkforceScheduler.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int MaxHoursPerWeek { get; set; }
        public bool IsActive { get; set; }
    }
}
