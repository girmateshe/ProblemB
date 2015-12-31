using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProblemB
{
    public abstract class SportTeams : ISportTeams
    {
        private readonly IDictionary<string, string> _teamsMascot;

        protected SportTeams()
        {
            var items = JsonConvert.DeserializeObject<List<TeamMascot>>(File.ReadAllText(GetSportTeamName() + ".json"));
            _teamsMascot = (IDictionary<string, string>)items.ToDictionary(x => x.Name.ToLower(), x => x.Mascot);
        }

        public string GetMascot(string teamName)
        {

            if (string.IsNullOrWhiteSpace(teamName))
            {
                return "No team name";
            }

            try
            {
                return _teamsMascot[teamName.ToLower()];
            }
            catch (Exception)
            {
                return "Unknown team name";
            }
        }
        public abstract string GetSportTeamName();
    }
}
