using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JobSearchTrackerAPI.Data;
using System;
using System.Linq;

namespace JobSearchTrackerAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new JobSearchTrackerAPIContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<JobSearchTrackerAPIContext>>()))
            {
                // Look for any ParentCompanies.
                if (context.ParentCompany.Any())
                {
                    // DB has been seeded
                }
                else
                {
                    context.ParentCompany.AddRange(
                        new ParentCompany
                        {
                            Title = "Self-Employed"
                        },

                        new ParentCompany
                        {
                            Title = "Apex Systems"
                        },

                        new ParentCompany
                        {
                            Title = "Brooksource"
                        },

                        new ParentCompany
                        {
                            Title = "SkillStorm"
                        },

                        new ParentCompany
                        {
                            Title = "TEKSystems"
                        }
                    );
                    context.SaveChanges();
                }
                // Look for any Recruiters.
                if (context.Recruiter.Any())
                {
                    // DB has been seeded
                }
                else
                {
                    context.Recruiter.AddRange(
                        new Recruiter
                        {
                            Name = "Self",
                            Title = "Master Recruiter",
                            ParentCompany = "Self-Employed",
                            ParentCompanyId = 1,
                            Email = "masterrecruiter@empowerment.com",
                            Phone = "9991239999",
                            LinkedIn = "https://www.linkedin.com/in/Self"
                        },
                        new Recruiter
                        {
                            Name = "Marky Mark",
                            Title = "Head Recruiter",
                            ParentCompany = "Apex Systems",
                            ParentCompanyId = 2,
                            Email = "markymark@apexS.com",
                            Phone = "9991239998",
                            LinkedIn = "https://www.linkedin.com/in/markyMark"
                        },
                        new Recruiter
                        {
                            Name = "Adelie Ada",
                            Title = "Recruiter",
                            ParentCompany = "Apex Systems",
                            ParentCompanyId = 2,
                            Email = "adelieada@apexS.com",
                            Phone = "9991239997",
                            LinkedIn = "https://www.linkedin.com/in/adelieAda"
                        },
                        new Recruiter
                        {
                            Name = "Barry Barnes",
                            Title = "Recruiter",
                            ParentCompany = "Apex Systems",
                            ParentCompanyId = 2,
                            Email = "barrybarnes@apexS.com",
                            Phone = "9991239996",
                            LinkedIn = "https://www.linkedin.com/in/barryBarnes"
                        },
                        new Recruiter
                        {
                            Name = "Charlie Chapman",
                            Title = "Head Recruiter",
                            ParentCompany = "Brooksource",
                            ParentCompanyId = 3,
                            Email = "charliechapman@brooks.com",
                            Phone = "9991239995",
                            LinkedIn = "https://www.linkedin.com/in/charlieChapman"
                        },
                        new Recruiter
                        {
                            Name = "Dil Daily",
                            Title = "Recruiter",
                            ParentCompany = "Brooksource",
                            ParentCompanyId = 3,
                            Email = "dildaily@brooks.com",
                            Phone = "9991239994",
                            LinkedIn = "https://www.linkedin.com/in/dilDaily"
                        },
                        new Recruiter
                        {
                            Name = "Emika Evans",
                            Title = "Head Recruiter",
                            ParentCompany = "SkillStorm",
                            ParentCompanyId = 4,
                            Email = "emikaevans@skills.com",
                            Phone = "9991239993",
                            LinkedIn = "https://www.linkedin.com/in/emikaEvans"
                        },
                        new Recruiter
                        {
                            Name = "Forest Farley",
                            Title = "Recruiter",
                            ParentCompany = "SkillStorm",
                            ParentCompanyId = 4,
                            Email = "emikaevans@skills.com",
                            Phone = "9991239992",
                            LinkedIn = "https://www.linkedin.com/in/forestFarley"
                        },
                        new Recruiter
                        {
                            Name = "Garett Gary",
                            Title = "Recruiter",
                            ParentCompany = "TEKSystems",
                            ParentCompanyId = 5,
                            Email = "garettgary@TEKS.com",
                            Phone = "9991239991",
                            LinkedIn = "https://www.linkedin.com/in/garettGary"
                        }
                    );
                    context.SaveChanges();
                }
                // Look for any Leads.
                if (context.Lead.Any())
                {
                    // DB has been seeded
                }
                else
                {
                    context.Lead.AddRange(
                        new Lead
                        {
                            RecruiterId = 1,
                            RecruiterName = "Self",
                            JobDescription = "Software Engineer",
                            JobDescriptionId = 1
                        },
                        new Lead
                        {
                            RecruiterId = 2,
                            RecruiterName = "Marky Mark",
                            JobDescription = "Software Engineer",
                            JobDescriptionId = 2
                        },
                        new Lead
                        {
                            RecruiterId = 2,
                            RecruiterName = "Marky Mark",
                            JobDescription = "Software Engineer",
                            JobDescriptionId = 3
                        },
                        new Lead
                        {
                            RecruiterId = 2,
                            RecruiterName = "Marky Mark",
                            JobDescription = "Software Developer",
                            JobDescriptionId = 4
                        },
                        new Lead
                        {
                            RecruiterId = 3,
                            RecruiterName = "Adelie Ada",
                            JobDescription = "Software Engineer",
                            JobDescriptionId = 5
                        },
                        new Lead
                        {
                            RecruiterId = 4,
                            RecruiterName = "Barry Barnes",
                            JobDescription = "Software Engineer",
                            JobDescriptionId = 6
                        },
                        new Lead
                        {
                            RecruiterId = 5,
                            RecruiterName = "Charlie Chapman",
                            JobDescription = "Software Engineer",
                            JobDescriptionId = 7
                        },
                        new Lead
                        {
                            RecruiterId = 5,
                            RecruiterName = "Charlie Chapman",
                            JobDescription = "Software Engineer",
                            JobDescriptionId = 8
                        },
                        new Lead
                        {
                            RecruiterId = 6,
                            RecruiterName = "Dil Daily",
                            JobDescription = "Software Developer",
                            JobDescriptionId = 9
                        },
                        new Lead
                        {
                            RecruiterId = 7,
                            RecruiterName = "Emika Evans",
                            JobDescription = "Software Engineer",
                            JobDescriptionId = 10
                        },
                        new Lead
                        {
                            RecruiterId = 7,
                            RecruiterName = "Emika Evans",
                            JobDescription = "Software Engineer",
                            JobDescriptionId = 11
                        },
                        new Lead
                        {
                            RecruiterId = 7,
                            RecruiterName = "Emika Evans",
                            JobDescription = "Software Developer",
                            JobDescriptionId = 12
                        },
                        new Lead
                        {
                            RecruiterId = 8,
                            RecruiterName = "Forest Farley",
                            JobDescription = "Support Engineer",
                            JobDescriptionId = 13
                        },
                        new Lead
                        {
                            RecruiterId = 9,
                            RecruiterName = "Garett Gary",
                            JobDescription = "Support Engineer",
                            JobDescriptionId = 14
                        },
                        new Lead
                        {
                            RecruiterId = 9,
                            RecruiterName = "Garett Gary",
                            JobDescription = "Support Engineer",
                            JobDescriptionId = 15
                        }
                    );
                    context.SaveChanges();
                }// Look for any JobDescriptions.
                if (context.JobDescription.Any())
                {
                    // DB has been seeded
                }
                else
                {
                    context.JobDescription.AddRange(
                        new JobDescription
                        {
                            JDescription = "Software Engineer",
                            DatePosted = DateTime.Parse("2020-5-1"),
                            DateApplied = DateTime.Parse("2020-5-2"),
                            Link = "https://www.linkedin.com/jobs/view/1859490001/",
                            MinQuals = 1,
                            QualificationsMet = 1,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Engineer",
                            DatePosted = DateTime.Parse("2020-5-2"),
                            DateApplied = DateTime.Parse("2020-5-3"),
                            Link = "https://www.linkedin.com/jobs/view/1859490002/",
                            MinQuals = 2,
                            QualificationsMet = 2,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Engineer",
                            DatePosted = DateTime.Parse("2020-5-3"),
                            DateApplied = DateTime.Parse("2020-5-4"),
                            Link = "https://www.linkedin.com/jobs/view/1859490011/",
                            MinQuals = 3,
                            QualificationsMet = 3,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Developer",
                            DatePosted = DateTime.Parse("2020-5-4"),
                            DateApplied = DateTime.Parse("2020-5-5"),
                            Link = "https://www.linkedin.com/jobs/view/1859490101/",
                            MinQuals = 4,
                            QualificationsMet = 4,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Engineer",
                            DatePosted = DateTime.Parse("2020-5-5"),
                            DateApplied = DateTime.Parse("2020-5-6"),
                            Link = "https://www.linkedin.com/jobs/view/1859491001/",
                            MinQuals = 5,
                            QualificationsMet = 5,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Engineer",
                            DatePosted = DateTime.Parse("2020-5-6"),
                            DateApplied = DateTime.Parse("2020-5-7"),
                            Link = "https://www.linkedin.com/jobs/view/1859500001/",
                            MinQuals = 6,
                            QualificationsMet = 6,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Engineer",
                            DatePosted = DateTime.Parse("2020-5-7"),
                            DateApplied = DateTime.Parse("2020-5-8"),
                            Link = "https://www.linkedin.com/jobs/view/1859590001/",
                            MinQuals = 7,
                            QualificationsMet = 6,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Engineer",
                            DatePosted = DateTime.Parse("2020-5-8"),
                            DateApplied = DateTime.Parse("2020-5-9"),
                            Link = "https://www.linkedin.com/jobs/view/1860490001/",
                            MinQuals = 8,
                            QualificationsMet = 7,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Developer",
                            DatePosted = DateTime.Parse("2020-5-9"),
                            DateApplied = DateTime.Parse("2020-5-10"),
                            Link = "https://www.linkedin.com/jobs/view/1869490001/",
                            MinQuals = 9,
                            QualificationsMet = 8,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Engineer",
                            DatePosted = DateTime.Parse("2020-5-10"),
                            DateApplied = DateTime.Parse("2020-5-11"),
                            Link = "https://www.linkedin.com/jobs/view/1959490001/",
                            MinQuals = 10,
                            QualificationsMet = 8,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Engineer",
                            DatePosted = DateTime.Parse("2020-5-11"),
                            DateApplied = DateTime.Parse("2020-5-12"),
                            Link = "https://www.linkedin.com/jobs/view/2859490001/",
                            MinQuals = 11,
                            QualificationsMet = 9,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Software Developer",
                            DatePosted = DateTime.Parse("2020-5-12"),
                            DateApplied = DateTime.Parse("2020-5-13"),
                            Link = "https://www.linkedin.com/jobs/view/1759490001/",
                            MinQuals = 12,
                            QualificationsMet = 10,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Support Engineer",
                            DatePosted = DateTime.Parse("2020-5-13"),
                            DateApplied = DateTime.Parse("2020-5-14"),
                            Link = "https://www.linkedin.com/jobs/view/1849490001/",
                            MinQuals = 13,
                            QualificationsMet = 10,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Support Engineer",
                            DatePosted = DateTime.Parse("2020-5-14"),
                            DateApplied = DateTime.Parse("2020-5-15"),
                            Link = "https://www.linkedin.com/jobs/view/1858490001/",
                            MinQuals = 14,
                            QualificationsMet = 11,
                            Notes = ""
                        },
                        new JobDescription
                        {
                            JDescription = "Support Engineer",
                            DatePosted = DateTime.Parse("2020-5-15"),
                            DateApplied = DateTime.Parse("2020-5-16"),
                            Link = "https://www.linkedin.com/jobs/view/1859390001/",
                            MinQuals = 15,
                            QualificationsMet = 12,
                            Notes = ""
                        }
                    );
                    context.SaveChanges();
                }
                // Look for any Qualifications.
                if (context.Qualification.Any())
                {
                    // DB has been seeded
                }
                else
                {
                    context.Qualification.AddRange(
                        new Qualification
                        {
                            JDescriptionId = 1,
                            Term= "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 2,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 2,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 3,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 3,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 3,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 4,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 4,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 4,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 4,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 5,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 5,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 5,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 5,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 5,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 6,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 6,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 6,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 6,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 6,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 6,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 7,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 7,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 7,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 7,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 7,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 7,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 7,
                            Term = "CSHTML",
                            DistinctQualificationId = 7
                        },

                        new Qualification
                        {
                            JDescriptionId = 8,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 8,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 8,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 8,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 8,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 8,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 8,
                            Term = "CSHTML",
                            DistinctQualificationId = 7
                        },

                        new Qualification
                        {
                            JDescriptionId = 8,
                            Term = "TSQL",
                            DistinctQualificationId = 8
                        },

                        new Qualification
                        {
                            JDescriptionId = 9,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 9,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 9,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 9,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 9,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 9,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 9,
                            Term = "CSHTML",
                            DistinctQualificationId = 7
                        },

                        new Qualification
                        {
                            JDescriptionId = 9,
                            Term = "TSQL",
                            DistinctQualificationId = 8
                        },

                        new Qualification
                        {
                            JDescriptionId = 9,
                            Term = "ASP.NET",
                            DistinctQualificationId = 9
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "CSHTML",
                            DistinctQualificationId = 7
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "TSQL",
                            DistinctQualificationId = 8
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "ASP.NET",
                            DistinctQualificationId = 9
                        },

                        new Qualification
                        {
                            JDescriptionId = 10,
                            Term = "Azure",
                            DistinctQualificationId = 10
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "CSHTML",
                            DistinctQualificationId = 7
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "TSQL",
                            DistinctQualificationId = 8
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "ASP.NET",
                            DistinctQualificationId = 9
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "Azure",
                            DistinctQualificationId = 10
                        },

                        new Qualification
                        {
                            JDescriptionId = 11,
                            Term = "Angular",
                            DistinctQualificationId = 11
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "CSHTML",
                            DistinctQualificationId = 7
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "TSQL",
                            DistinctQualificationId = 8
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "ASP.NET",
                            DistinctQualificationId = 9
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "Azure",
                            DistinctQualificationId = 10
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "Angular",
                            DistinctQualificationId = 11
                        },

                        new Qualification
                        {
                            JDescriptionId = 12,
                            Term = "Kubernetes",
                            DistinctQualificationId = 12
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "CSHTML",
                            DistinctQualificationId = 7
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "TSQL",
                            DistinctQualificationId = 8
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "ASP.NET",
                            DistinctQualificationId = 9
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "Azure",
                            DistinctQualificationId = 10
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "Angular",
                            DistinctQualificationId = 11
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "Kubernetes",
                            DistinctQualificationId = 12
                        },

                        new Qualification
                        {
                            JDescriptionId = 13,
                            Term = "SharePoint",
                            DistinctQualificationId = 13
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "CSHTML",
                            DistinctQualificationId = 7
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "TSQL",
                            DistinctQualificationId = 8
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "ASP.NET",
                            DistinctQualificationId = 9
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "Azure",
                            DistinctQualificationId = 10
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "Angular",
                            DistinctQualificationId = 11
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "Kubernetes",
                            DistinctQualificationId = 12
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "SharePoint",
                            DistinctQualificationId = 13
                        },

                        new Qualification
                        {
                            JDescriptionId = 14,
                            Term = "Masters Degree",
                            DistinctQualificationId = 16
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "Python",
                            DistinctQualificationId = 1
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "C",
                            DistinctQualificationId = 2
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "C#",
                            DistinctQualificationId = 3
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "C++",
                            DistinctQualificationId = 4
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "CSS",
                            DistinctQualificationId = 5
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "HTML",
                            DistinctQualificationId = 6
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "CSHTML",
                            DistinctQualificationId = 7
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "TSQL",
                            DistinctQualificationId = 8
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "ASP.NET",
                            DistinctQualificationId = 9
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "Azure",
                            DistinctQualificationId = 10
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "Angular",
                            DistinctQualificationId = 11
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "Kubernetes",
                            DistinctQualificationId = 12
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "SharePoint",
                            DistinctQualificationId = 13
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "Masters Degree",
                            DistinctQualificationId = 16
                        },

                        new Qualification
                        {
                            JDescriptionId = 15,
                            Term = "3 years experience",
                            DistinctQualificationId = 19
                        }
                    );
                    context.SaveChanges();
                }
                // Look for any DistinctQualifications.
                if (context.DistinctQual.Any())
                {
                    // DB has been seeded
                }
                else
                {
                    context.DistinctQual.AddRange(
                        new DistinctQual
                        {
                            Term= "Python"
                        },

                        new DistinctQual
                        {
                            Term = "C"
                        },

                        new DistinctQual
                        {
                            Term = "C#"
                        },

                        new DistinctQual
                        {
                            Term = "C++"
                        },

                        new DistinctQual
                        {
                            Term = "CSS"
                        },

                        new DistinctQual
                        {
                            Term = "HTML"
                        },

                        new DistinctQual
                        {
                            Term = "CSHTML"
                        },

                        new DistinctQual
                        {
                            Term = "TSQL"
                        },

                        new DistinctQual
                        {
                            Term = "ASP.Net"
                        },

                        new DistinctQual
                        {
                            Term = "Azure"
                        },

                        new DistinctQual
                        {
                            Term = "Angular"
                        },

                        new DistinctQual
                        {
                            Term = "Kubernetes"
                        },

                        new DistinctQual
                        {
                            Term = "SharePoint"
                        },

                        new DistinctQual
                        {
                            Term = "Associates Degree"
                        },

                        new DistinctQual
                        {
                            Term = "Bachelors Degree"
                        },

                        new DistinctQual
                        {
                            Term = "Masters Degree"
                        },

                        new DistinctQual
                        {
                            Term = "1 year experience"
                        },

                        new DistinctQual
                        {
                            Term = "2 years experience"
                        },

                        new DistinctQual
                        {
                            Term = "3 years experience"
                        },

                        new DistinctQual
                        {
                            Term = "4 years experience"
                        },

                        new DistinctQual
                        {
                            Term = "5 years experience"
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
