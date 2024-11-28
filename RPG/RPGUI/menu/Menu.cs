using Microsoft.IdentityModel.Tokens;
using RPG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RPGUI
{
    public partial class Menu : Form
    {
        private User user1 { get; set; }
        private User user2 { get; set; }
        private BattleTeams team1 { get; set; }
        private BattleTeams team2 { get; set; }
        private SQL connection = SQL.Instance;
        public Menu()
        {
            InitializeComponent();

            //loggin / logout
            button1.Click += (sender, e) => LogInOut(sender, e, 1);
            button2.Click += (sender, e) => LogInOut(sender, e, 2);
            //edit teams
            button3.Click += (sender, e) => Edit_Button(sender, e, 1);
            button4.Click += (sender, e) => Edit_Button(sender, e, 2);
        }
        /// <summary>
        /// Loggin & SignUp / Verify user is already logged in
        /// Get user team pre-set from SQL Database and if there is not team preset force player to choose one and insert it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="i"> Player 1 or Player 2</param>
        private void LogInOut(object sender, EventArgs e, int i)
        {
            if (i == 1)
            {
                if (user1 == null || !user1.loggedIn) // Check if user1 is null or not logged in
                {
                    Login login = new Login();
                    login.ShowDialog();
                    //if login page is closed
                    if(login.user is null)
                    {
                        return;
                    }
                    // Check if user2 is logged in with the same username
                    if (user2 != null && user2.loggedIn && login.user.username == user2.username)
                    {
                        MessageBox.Show("This user is already logged in as Player 2.");
                        return;
                    }
                    else if(!login.user.username.IsNullOrEmpty())
                    {
                        user1 = new User(login.user.username, 0, 0);
                        user1.loggedIn = true; // Ensure loggedIn is set to true when logging in

                        // Show UI elements for player 1
                        textBoxUser1.Text = login.user.username;
                        textBoxUser1.Visible = true;
                        //fetch team and display it
                        if(!TeamLoad(login.user.username, i))
                        {
                            Team chooseTeam = new Team();
                            chooseTeam.ShowDialog();
                            team1 = chooseTeam.SelectedTeam;
                        }
                        logShow(1);
                    }
                }
                else
                {
                    hide(1);
                }
            }
            else if (i == 2)
            {
                if (user2 == null || !user2.loggedIn) // Check if user2 is null or not logged in
                {
                    Login login = new Login();
                    login.ShowDialog();
                    if (user1 != null && user1.loggedIn && login.user.username == user1.username)
                    {
                        MessageBox.Show("This user is already logged in as Player 1.");
                        return;
                    }
                    else if (login.user!=null && !login.user.username.IsNullOrEmpty())
                    {
                        user2 = new User(login.user.username, 0, 0);
                        user2.loggedIn = true; // Ensure loggedIn is set to true when logging in

                        // Show UI elements for player 1
                        textBoxUser2.Text = login.user.username;
                        textBoxUser2.Visible = true;
                        //fetch team and display it
                        if (!TeamLoad(login.user.username, i))
                        {
                            Team chooseTeam = new Team();
                            chooseTeam.ShowDialog();
                            team2 = chooseTeam.SelectedTeam;
                        }
                        logShow(2);
                    }
                }
                else
                {
                    hide(2);
                }
            }

            // Check if both users are logged in before showing a start game button
            buttonStart();
        }
        private void logShow(int user)
        {
            switch (user)
            {
                case 1:
                    //write in boxes the characters names
                    textBox1.Text = this.team1.team[0].name;
                    textBox2.Text = this.team1.team[1].name;
                    textBox3.Text = this.team1.team[2].name;
                    //insert characters img to the picturebox
                    pictureBox1 = BoxImage(this.team1.team[0], pictureBox1);
                    pictureBox2 = BoxImage(this.team1.team[1], pictureBox2);
                    pictureBox3 = BoxImage(this.team1.team[2], pictureBox3);
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    //text visible
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    button1.Text = "Logout";
                break;
                case 2:
                    //write in boxes the characters names
                    textBox4.Text = this.team2.team[0].name;
                    textBox5.Text = this.team2.team[1].name;
                    textBox6.Text = this.team2.team[2].name;
                    //insert characters img to the picturebox
                    pictureBox4 = BoxImage(this.team2.team[0], pictureBox4);
                    pictureBox5 = BoxImage(this.team2.team[1], pictureBox5);
                    pictureBox6 = BoxImage(this.team2.team[2], pictureBox6);
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    //text visible
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    button2.Text = "Logout";
                break;
            }
        }
        private void hide(int user)
        {
            switch (user)
            {
                case 1:
                    // Log out user1
                    user1 = null;

                    // Hide UI elements for player 1
                    textBoxUser1.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    button3.Visible = false;
                    button1.Text = "Login";
                break;
                case 2:
                    // Log out user2
                    user2 = null;

                    // Hide UI elements for player 2
                    textBox2.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    button4.Visible = false;
                    button2.Text = "Login";
                break;
            }
        }
        /// <summary>
        /// Load  characther icons in the menu
        /// </summary>
        /// <param name="character"></param>
        /// <param name="pic"></param>
        /// <returns></returns>
        public PictureBox BoxImage(Class character, PictureBox pic)
        {
            if(character is Warrior)
            {
                pic.Image = Properties.Resources.Warrior;
                return pic;
            }
            if(character is Paladin)
            {
                pic.Image = Properties.Resources.paladin;
                return pic;
            }
            if(character is Swordsman)
            {
                pic.Image = Properties.Resources.sword;
                return pic;
            }
            if(character is Assassin)
            {
                pic.Image = Properties.Resources.assassin;
                return pic;
            }
            if(character is Archer)
            {
                pic.Image = Properties.Resources.archer;
                return pic;
            }
            if(character is Mage)
            {
                pic.Image = Properties.Resources.sage;
                return pic;
            }
            return pic;
        }
        
        /// <summary>
        /// Load team from database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public bool TeamLoad(string username, int j)
        {
            int[] characters;
            if (!connection.GetTeamData(username, out characters))
            {
                return false;
            }

            if (j == 1)
            {
                team1 = new BattleTeams();
            }
            else if (j == 2)
            {
                team2 = new BattleTeams();
            }

            for (int i = 0; i < 3; i++)
            {
                switch (characters[i])
                {
                    case 1:
                        team1.add(new Warrior(250, 50, 70, 50));
                        break;
                    case 2:
                        team1.add(new Paladin(220, 60, 50, 30));
                        break;
                    case 3:
                        team1.add(new Swordsman(210, 40, 80, 40));
                        break;
                    case 4:
                        team1.add(new Assassin(180, 30, 60, 90, 40));
                        break;
                    case 5:
                        team1.add(new Archer(190, 35, 50, 100, 30));
                        break;
                    case 6:
                        team1.add(new Mage(160, 20, 40, 90, 50));
                        break;
                }
            }
            return true;
        }
        private void buttonStart()
        {
            // Check if both users are logged in
            if (user1 != null && user2 != null)
            {
                button5.Visible = true; // Show "Start Game" button
            }
            else
            {
                button5.Visible = false;
            }
        }
        private void Edit_Button(object sender, EventArgs e, int i)
        {
            if (i == 1)
            {
                // Pass player1 data to the Edit form
                Edit editForm = new Edit(team1);
                editForm.ShowDialog(); // Or use Show() depending on your need
                this.team1 = editForm.getTeam;
            }
            if (i == 2)
            {
                // Pass player1 data to the Edit form
                Edit editForm = new Edit(team2);
                editForm.ShowDialog(); // Or use Show() depending on your need
                this.team2 = editForm.getTeam;
            }
        }
        private void buttonScoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.ShowDialog();
        }
    }
}
