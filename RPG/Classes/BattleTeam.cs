﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class BattleTeams
    {
        private bool FullTeam { get; set; }
        private List<Class> team { get; set; }

        public BattleTeams(int id, Class c1, Class c2, Class c3)
        {
            this.FullTeam = true;
            this.team = new List<Class>() { c1, c2, c3};
        }
        public List<Class> Team { get { return this.team; } }
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
