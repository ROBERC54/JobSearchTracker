using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchTrackerAPI.Models
{
    public class Qualification
    {
        public int Id { get; set; }
        public int JDescriptionId { get; set; }
        public string Term { get; set; }
        public int DistinctQualificationId { get; set; }
    }
}
