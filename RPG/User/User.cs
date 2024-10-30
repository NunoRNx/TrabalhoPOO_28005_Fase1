using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class User
    {
        private string Username { get; set; }
        private bool LogedIn { get; set; }
        private int Wins { get; set; }
        private int Matchs { get; set; }
        public User(string username, int wins, int matchs)
        {
            this.Username = username;
            this.LogedIn = true;
            this.Wins = wins;
            this.Matchs = matchs;
        }
        public string username
        {
            get { return this.Username; }
            set
            {
                if (this.Username == value)
                {
                    throw new ArgumentException("Same username");
                }
                else if (this.Username == null)
                {
                    throw new NullReferenceException("No username inserted");
                }
                this.Username = value;
            }
        }
        public bool loggedIn
        {
            get { return this.LogedIn; }
            set { this.LogedIn = value; }
        }
        public int wins
        {
            get { return this.Wins; }
            set { this.Wins = value; }
        }
        public int matchs
        {
            get { return this.Matchs; }
            set { this.Matchs = value; }
        }
    }
}
