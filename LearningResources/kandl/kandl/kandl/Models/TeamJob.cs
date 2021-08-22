using System;
using System.Collections.Generic;
using System.Text;

namespace kandl.Models
{
    public class TeamJob : Job
    {
        public Team Team { get; set; }

        public string BackgroundColor
        {
            get
            {
                return Team?.BackgroundColor;
            }
        }


        public TeamJob(Team team) : base()
        {
            this.Team = team;
        }
        public TeamJob(Job job, Team team) : base()
        {
            this.ID = job.ID;
            this.Description = job.Description;
            this.Requirements = job.Requirements;
            this.Title = job.Title;
            this.TeamID = job.TeamID;
            this.Team = team;
            this.Tags = job.Tags.GetRange(0, job.Tags.Count);
        }
    }
}
