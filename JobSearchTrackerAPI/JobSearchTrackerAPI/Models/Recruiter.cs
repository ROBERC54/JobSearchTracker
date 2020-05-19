using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchTrackerAPI.Models
{
    public class Recruiter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ParentCompany { get; set; }
        public int ParentCompanyId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string LinkedIn { get; set; }

    }
}
