namespace WorkforceScheduler.Models
{
    public class Shifts
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string RequiredSkill { get; set; } = "";
    }
}
