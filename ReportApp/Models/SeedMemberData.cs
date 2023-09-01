using Microsoft.EntityFrameworkCore;
using ReportApp.Data;

namespace ReportApp.Models
{
    public class SeedMemberData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ReportAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ReportAppContext>>()))
            {
                // Look for any member.
                if (context.Member.Any())
                {
                    return;   // DB has been seeded
                }
                context.Member.AddRange(
                    new Member
                    {
                        Name = "Dustin Dyckmanns",
                        Signature = "D. Dyckmanns",
                        JoinedAt = DateTime.Parse("2020-08-01"),
                        IsTrainee = true
                    },
                    new Member
                    {
                        Name = "Paolo Viola",
                        Signature = "P. Viola",
                        JoinedAt = DateTime.Parse("2022-08-01"),
                        IsTrainee = true
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
