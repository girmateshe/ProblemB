using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a team name...");
            var teamName = Console.ReadLine();

            var footbalTeams = new FootballTeams();
            var mascot = footbalTeams.GetMascot(teamName);

            Console.WriteLine(mascot);
            Console.ReadLine();
        }
    }
}
