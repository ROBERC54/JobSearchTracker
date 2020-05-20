using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobSearchTrackerAPI.Models;

namespace JobSearchTrackerAPI.Data
{
    public class JobSearchTrackerAPIContext : DbContext
    {
        public JobSearchTrackerAPIContext(DbContextOptions<JobSearchTrackerAPIContext> options)
            : base(options)
        {
        }
        public DbSet<DistinctQual> DistinctQual { get; set; }
        public DbSet<JobDescription> JobDescription { get; set; }
        public DbSet<Lead> Lead { get; set; }
        public DbSet<ParentCompany> ParentCompany { get; set; }
        public DbSet<Qualification> Qualification { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
    }
}
