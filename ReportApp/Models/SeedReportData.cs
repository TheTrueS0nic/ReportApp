using Microsoft.EntityFrameworkCore;
using ReportApp.Data;

namespace ReportApp.Models
{
    public class SeedReportData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ReportAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ReportAppContext>>()))
            {
                // Look for any member.
                if (context.Report.Any())
                {
                    return;   // DB has been seeded
                }
                context.Report.AddRange(
                    new Report
                    {
                        Content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
