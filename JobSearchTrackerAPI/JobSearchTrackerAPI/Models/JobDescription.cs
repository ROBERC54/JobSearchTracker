using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JobSearchTrackerAPI.Models
{
    public class JobDescription
    {
        public int Id { get; set; }
        public string JDescription { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateApplied { get; set; }
        public string Link { get; set; }
        public int MinQuals { get; set; }
        public int QualificationsMet { get; set; }
        public string Notes { get; set; }
    }
}
