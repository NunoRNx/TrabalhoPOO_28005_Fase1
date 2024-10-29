using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class BattleTeams
    {
        private List<Class> team { get; set; }

        public BattleTeams(Class c1, Class c2, Class c3)
        {
            team = new List<Class>()
            {
                c1, c2, c3
            };
        }
        public List<Class> GetTeam()
        {
            return team;
        }
        public void change(Class old, Class now)
        {
            team.Remove(old);
            team.Add(now);
        }
    }
}
