using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ReportApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Signature { get; set; }
        [Display(Name = "Joined at")]
        public DateTime JoinedAt { get; set; }
        [Display(Name = "Is a Trainee")]
        public bool IsTrainee { get; set; }

    }
}
