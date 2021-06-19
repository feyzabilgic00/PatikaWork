using System;
using System.Collections.Generic;

namespace todo_appliction
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TeamMember> GetTeamMembers()
        {
            List<TeamMember> teamMembers=new List<TeamMember>()
            {
                new TeamMember{Id=1,Name="Feyza"},
                new TeamMember{Id=2,Name="Cahide"},
                new TeamMember{Id=3,Name="Naime"},
                new TeamMember{Id=4,Name="Züleyha"},
                new TeamMember{Id=1,Name="Hatice"},
                new TeamMember{Id=2,Name="İrem"},
                new TeamMember{Id=3,Name="Kübra"},
                new TeamMember{Id=4,Name="Fatma"},
            };
            return teamMembers;
        }
    }
}