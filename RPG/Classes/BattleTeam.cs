using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class BattleTeams
    {
        private int TeamID { get; set; }
        private Class C1 { get; set; }
        private Class C2 { get; set; }
        private Class C3 { get; set; }
        /*private List<Class> team { get; set; }*/

        public BattleTeams(int id, Class c1, Class c2, Class c3)
        {
            this.TeamID = id;
            this.C1 = c1;
            this.C2 = c2;
            this.C3 = c3;
            /*this.team = new List<Class>() { c1, c2, c3};*/
        }
        public Class c1
        {
            get { return this.C1; }
            set { this.C1 = value; }
        }
        public Class c2
        {
            get { return this.C2; }
            set { this.C2 = value; }
        }
        public Class c3
        {
            get { return this.C3; }
            set { this.C3 = value; }
        }


        /*public List<Class> GetTeam()
        {
            return team;
        }
        public void change(Class old, Class now)
        {
            team.Remove(old);
            team.Add(now);
        }*/
    }
}
