using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobSearchTrackerAPI.Models;

namespace JobSearchTrackerAPI.Data
{
    public class CADFundamentalsWebAPIContext : DbContext
    {
        public CADFundamentalsWebAPIContext(DbContextOptions<CADFundamentalsWebAPIContext> options)
            : base(options)
        {
        }
    }
}
