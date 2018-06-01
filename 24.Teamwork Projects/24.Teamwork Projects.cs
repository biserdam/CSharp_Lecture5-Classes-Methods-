using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var teamsList = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var inputSplitted = input.Split('-');
                var creator = inputSplitted[0];
                var teamName = inputSplitted[1];
                if (!teamsList.Exists(x => x.creator == creator))
                {
                    if (!teamsList.Exists(x => x.name == teamName))
                    {
                        teamsList.Add(new Team(teamName, creator));
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else Console.WriteLine($"Team {teamName} was already created!");
                }
                else Console.WriteLine($"{creator} cannot create another team!");
            }

            var inputString = Console.ReadLine();
            while (inputString != "end of assignment")
            {
                var inputStringSplit = inputString.Split('-');
                var userName = inputStringSplit[0];
                var teamToJoin = inputStringSplit[1].Remove(0, 1);

                if (teamsList.Exists(x => x.name == teamToJoin))
                {
                    if (!teamsList.Exists(x => x.usersList.Contains(userName)) && !teamsList.Exists(x => x.creator == userName))
                    {
                        teamsList.Find(x => x.name == teamToJoin).usersList.Add(userName);
                    }
                    else Console.WriteLine($"Member {userName} cannot join team {teamToJoin}!");
                }
                else Console.WriteLine($"Team {teamToJoin} does not exist!");

                inputString = Console.ReadLine();
            }

            var teamsListSorted = teamsList.OrderByDescending(x => x.usersList.Count).ThenBy(x => x.name);

            foreach (var team in teamsListSorted)
            {
                if (team.usersList.Count > 0)
                {
                    Console.WriteLine(team.name);
                    Console.WriteLine($"- {team.creator}");
                    foreach (var user in team.usersList)
                    {
                        Console.WriteLine($"-- {user}");
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsListSorted)
            {
                if (team.usersList.Count == 0)
                {
                    Console.WriteLine(team.name);
                }
            }
        }

        public class Team
        {
            public string name;
            public string creator;
            public List<string> usersList = new List<string>();

            public Team(string name, string creator)
            {
                this.name = name;
                this.creator = creator;
            }

            public override string ToString()
            {
                return $"name:{name}, creator:{creator}, users:{string.Join(";", usersList)}, users count:{usersList.Count}".ToString();
            }
        }
    }
}
    
