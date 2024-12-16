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
        private int Matches { get; set; }
        public User(string username, int wins, int matches)
        {
            this.Username = username;
            this.LogedIn = true;
            this.Wins = wins;
            this.Matches = matches;
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
        public int matches
        {
            get { return this.Matches; }
            set { this.Matches = value; }
        }
        ~User()
        {
            // This is called when the object is being garbage collected
            // Use this to release unmanaged resources if any were used.
            // Optionally: you can add logic here to release any unmanaged resources
        }
    }
}
