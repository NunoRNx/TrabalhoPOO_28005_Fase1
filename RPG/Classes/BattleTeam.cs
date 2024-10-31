using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class BattleTeams
    {
        private bool FullTeam { get; set; }
        private List<Class> Team { get; set; }

        public BattleTeams()
        {
            this.FullTeam = true;
            this.Team = new List<Class>();
        }
        public List<Class> team { get { return this.Team; } }
        public List<Class> add(Class charc)
        {
            team.Add(charc);
            return team;
        }
        public List<Class> remove(Class charc)
        {
            team.Remove(charc);
            return team;
        }
    }
}
