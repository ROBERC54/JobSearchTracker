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
    }
}
