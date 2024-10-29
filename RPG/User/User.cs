using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class User
    {
        private int UserID {  get; set; }
        private string Username { get; set; }
        private bool LogedIn { get; set; }
        private int Wins { get; set; }
        private int Matchs { get; set; }
        public User(string username, int wins, int matchs)
        {
            this.Username = username;
            this.LogedIn = false;
            this.Wins = wins;
            this.Matchs = matchs;
        }
        public int userID
        {
            get { return this.UserID; }
            set { this.userID = value; }
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
        public bool logedIn
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
