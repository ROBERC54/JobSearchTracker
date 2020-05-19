using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JobSearchTrackerAPI.Models
{
    public class Lead
    {
        public int Id { get; set; }
        public int RecruiterId { get; set; }
        public string RecruiterName { get; set; }
        public string JobDescription { get; set; }
        public int JobDescriptionId { get; set; }
    }
}
