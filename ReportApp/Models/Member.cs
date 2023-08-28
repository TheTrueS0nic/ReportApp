namespace ReportApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Signature { get; set; }
        public DateTime JoinedAt { get; set; }
        public bool IsTrainee { get; set; }

    }
}
