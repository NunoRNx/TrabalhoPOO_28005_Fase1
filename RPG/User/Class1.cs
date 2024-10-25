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
        private string Passwd { get; set; }
        private int Wins { get; set; }
        private int Matchs { get; set; }
        public User(string username, string passwd, int wins, int matchs)
        {
            this.Username = username;
            this.Passwd = passwd;
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
            }
    }
}
