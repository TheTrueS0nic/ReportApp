using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReportApp.Models;

namespace ReportApp.Data
{
    public class ReportAppContext : DbContext
    {
        public ReportAppContext (DbContextOptions<ReportAppContext> options)
            : base(options)
        {
        }

        public DbSet<ReportApp.Models.Report> Report { get; set; } = default!;

        public DbSet<ReportApp.Models.Member> Member { get; set; } = default!;
    }
}
