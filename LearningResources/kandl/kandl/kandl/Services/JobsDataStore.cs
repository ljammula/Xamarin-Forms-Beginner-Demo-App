using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kandl.Models;

namespace kandl.Services
{
    public class JobsDataStore : IJobsDataStore
    {
        List<Job> jobs;
        readonly IEnumerable<Team> teams;
        public JobsDataStore(IEnumerable<Team> teams)
        {
            this.teams = teams;
            jobs = GetJobs();
        }

        public async Task<Job> GetItemAsync(string id)
        {
            return await Task.FromResult(jobs.FirstOrDefault(s => s.ID == id));
        }

        public async Task<IEnumerable<Job>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(jobs);
        }

        public TeamJob GetTeamJobFromJob(Job job)
        {
            var team = teams.FirstOrDefault(t => t.ID == job.TeamID);

            return new TeamJob(job, team);
        }


        public List<TeamJob> GetTeamJobs()
        {
            var TeamJobs = new List<TeamJob>();

            foreach (var job in jobs)
            {
                TeamJobs.Add(GetTeamJobFromJob(job));
            }

            return TeamJobs;
        }

        private List<Job> GetJobs()
        {
            jobs = new List<Job>();

            var t1 = teams.FirstOrDefault();
            var t2 = teams.Skip(1).FirstOrDefault();
            var t3 = teams.Skip(2).FirstOrDefault();

            jobs.Add(new Job
            {
                Title = "Entry level Xamarin developer",
                TeamID = t1?.ID,
                Description = "Exciting new startup needs to ramp up fast and is looking for college graduates who can learn on their feet",
                Requirements = "College degree or equivalent experience.",
                Tags = new List<string> { "Xamarin", "Developer" }
            });

            jobs.Add(new Job
            {
                Title = "QA Analyst",
                TeamID = t2?.ID,
                Description = "The QA Analyst will provide high-level software module testing for the Suite. They are expected to develop and maintain a strong detailed level of knowledge of the modules assigned.",
                Requirements = "2 years of QA experience, SQL",
                Tags = new List<string> { "QA", "SQL" }
            });

            jobs.Add(new Job
            {
                Title = "Automation Tester",
                TeamID = t3?.ID,
                Description = "Our client is currently seeking a Senior Automation Tester to maintain and expand automated framework test scripts. This is a contract to hire position.",
                Requirements = "College Degree, 4 years of QA experience, SQL, C#",
                Tags = new List<string> { "QA", "SQL", "C#" }
            });
            jobs.Add(new Job
            {
                Title = "Tester",
                TeamID = t3?.ID,
                Description = "This position would require someone with a technical background in advanced computer skills, as well as the ability to analyze data sets for quality assurance.",
                Requirements = "College degree or equivalent experience",
                Tags = new List<string> { "QA" }
            });
            jobs.Add(new Job
            {
                Title = "Senior Software Engineer",
                TeamID = t1?.ID,
                Description = "Seeking full-stack developer for ecommerce and mobile applications using the .NET stack.",
                Requirements = "College degree or equivalent experience. 2+ years with Visual Studio with web or mobile",
                Tags = new List<string> { "C#", "Web", "Xamarin" }
            });
            jobs.Add(new Job
            {
                Title = "Smartphone App Developer",
                TeamID = t1?.ID,
                Description = "Seeking smartphone app developer",
                Requirements = "Smartphone app design and development experience",
                Tags = new List<string> { "C#", "iOS", "Android", "Xcode", "Android Studio" }
            });
            jobs.Add(new Job
            {
                Title = "Senior Software Engineer, Android (Xamarin)",
                TeamID = t1?.ID,
                Description = "Seeking senior C# developers with a passion for clean code and a strong interest in becoming Android developers",
                Requirements = "4 years of C#",
                Tags = new List<string> { "C#", "Android" }
            });

            return jobs;
        }

        public async Task<Job> GetNewestJobAsync()
        {
            return await Task.FromResult(jobs.LastOrDefault());
        }

    }
}
