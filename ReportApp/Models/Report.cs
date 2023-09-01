using System.ComponentModel.DataAnnotations;

namespace ReportApp.Models
{
    public class Report
    {
        public int Id { get; set; }
        [Display(Name = "Trainee")]
        public int OriginatorId { get; set; }
        [Display(Name = "Trainer")]
        public int ReviewerId { get; set; }
        public required string Content { get; set; }
        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set;}
        public DateTime? ApprovalDate { get; set; }
        public bool Denied { get; set; }
    }
}
