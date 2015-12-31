using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB
{
    public class FootballTeams : SportTeams, ISportTeams
    {
        public override string GetSportTeamName()
        {
            return "football";
        }
    }
}