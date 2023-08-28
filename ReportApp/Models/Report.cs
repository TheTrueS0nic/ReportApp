namespace ReportApp.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int OriginatorId { get; set; }
        public int ReviewerId { get; set; }
        public required string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set;}
        public DateTime? ApprovalDate { get; set; }
        public bool Denied { get; set; }
    }
}
