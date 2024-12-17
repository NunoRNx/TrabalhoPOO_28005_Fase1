using Microsoft.IdentityModel.Tokens;
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

using BattleController;
using RPG;

namespace RPGUI
{
    public partial class Menu : Form
    {
        private User user1 { get; set; }
        private User user2 { get; set; }
        private BattleTeams team1 { get; set; }
        private BattleTeams team2 { get; set; }
        private SQL connection = SQL.Instance;
        private Controller Battle;
        public Menu()
        {
            InitializeComponent();

            //loggin / logout
            button1.Click += (sender, e) => LogInOut(sender, e, 1);
            button2.Click += (sender, e) => LogInOut(sender, e, 2);
            //edit teams
            buttonEdit1.Click += (sender, e) => Edit_Button(sender, e, 1);
            buttonEdit2.Click += (sender, e) => Edit_Button(sender, e, 2);
            StartButton.Click += buttonStart_Click;
        }
        #region login/out
        /// <summary>
        /// Loggin & SignUp / Verify user is already logged in
        /// Get user team pre-set from SQL Database and if there is not team preset force player to choose one and insert it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="i"> Player 1 or Player 2</param>
        private void LogInOut(object sender, EventArgs e, int i)
        {
            this.Hide();
            if (i == 1)
            {
                if (user1 == null || !user1.loggedIn) // Check if user1 is null or not logged in
                {

                    Login login = new Login();
                    login.StartPosition = FormStartPosition.CenterScreen;
                    login.ShowDialog();
                    //if login page is closed
                    if (login.user is null)
                    {
                        this.Show();
                        return;
                    }
                    // Check if user2 is logged in with the same username
                    if (user2 != null && user2.loggedIn && login.user.username == user2.username)
                    {
                        MessageBox.Show("This user is already logged in.");
                        this.Show();
                        return;
                    }
                    else if (!login.user.username.IsNullOrEmpty())
                    {
                        user1 = new User(login.user.username, 0, 0);
                        user1.loggedIn = true; // Ensure loggedIn is set to true when logging in

                        // Show UI elements for player 1
                        textBoxUser1.Text = login.user.username;
                        textBoxUser1.Visible = true;
                        //fetch team and display it
                        BattleTeams team = new BattleTeams();
                        if (!TeamLoad(login.user.username, out team))
                        {
                            Team chooseTeam = new Team();
                            chooseTeam.StartPosition = FormStartPosition.CenterScreen;
                            chooseTeam.ShowDialog();
                            team1 = chooseTeam.SelectedTeam;
                            connection.InsertTeam(team1, user1.username);
                        }
                        else
                        {
                            team1 = team;
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
                    login.StartPosition = FormStartPosition.CenterScreen;
                    login.ShowDialog();
                    if (user1 != null && user1.loggedIn && login.user.username == user1.username)
                    {
                        MessageBox.Show("This user is already logged in.");
                        this.Show();
                        return;
                    }
                    else if (login.user != null && !login.user.username.IsNullOrEmpty())
                    {
                        user2 = new User(login.user.username, 0, 0);
                        user2.loggedIn = true; // Ensure loggedIn is set to true when logging in

                        // Show UI elements for player 1
                        textBoxUser2.Text = login.user.username;
                        textBoxUser2.Visible = true;
                        //fetch team and display it
                        BattleTeams team = new BattleTeams();
                        if (!TeamLoad(login.user.username, out team))
                        {
                            Team chooseTeam = new Team();
                            chooseTeam.StartPosition = FormStartPosition.CenterScreen;
                            chooseTeam.ShowDialog();
                            team2 = chooseTeam.SelectedTeam;
                            connection.InsertTeam(team2, user2.username);
                        }
                        else
                        {
                            team2 = team;
                        }
                        logShow(2);
                    }
                }
                else
                {
                    hide(2);
                }
            }
            this.Show();
            // Check if both users are logged in before showing a start game button
            buttonStart();
        }
        /// <summary>
        /// After user login, show all boxes and team preset
        /// </summary>
        /// <param name="user"></param>
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
                    //enable edit team button
                    buttonEdit1.Visible = true;
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
                    //enable edit team button
                    buttonEdit2.Visible = true;
                    break;
            }
        }
        /// <summary>
        /// Hide things after user logout
        /// </summary>
        /// <param name="user"></param>
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
                    buttonEdit1.Visible = false;
                    button1.Text = "Login";
                    //hide edit team button
                    buttonEdit1.Visible = false;
                    break;
                case 2:
                    // Log out user2
                    user2 = null;

                    // Hide UI elements for player 2
                    textBoxUser2.Visible = false;
                    textBox2.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    buttonEdit2.Visible = false;
                    button2.Text = "Login";
                    //hide edit team button
                    buttonEdit2.Visible = false;
                    break;
            }
        }
        #endregion
        #region picture loading
        /// <summary>
        /// Load  characther icons in the menu
        /// </summary>
        /// <param name="character"></param>
        /// <param name="pic"></param>
        /// <returns></returns>
        public PictureBox BoxImage(Class character, PictureBox pic)
        {
            if (character is Warrior)
            {
                pic.Image = Properties.Resources.Warrior;
                return pic;
            }
            if (character is Paladin)
            {
                pic.Image = Properties.Resources.paladin;
                return pic;
            }
            if (character is Swordsman)
            {
                pic.Image = Properties.Resources.sword;
                return pic;
            }
            if (character is Assassin)
            {
                pic.Image = Properties.Resources.assassin;
                return pic;
            }
            if (character is Archer)
            {
                pic.Image = Properties.Resources.archer;
                return pic;
            }
            if (character is Mage)
            {
                pic.Image = Properties.Resources.sage;
                return pic;
            }
            return pic;
        }
        #endregion
        #region Load team preset
        /// <summary>
        /// Load team from database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public bool TeamLoad(string username, out BattleTeams team)
        {
            team = new BattleTeams();
            int[] characters;
            if (!connection.GetTeamData(username, out characters))
            {
                return false;
            }

            for (int i = 0; i < 3; i++)
            {
                switch (characters[i])
                {
                    case 1:
                        team.add(new Warrior(250, 50, 70, 50));
                        break;
                    case 2:
                        team.add(new Paladin(220, 60, 50, 30));
                        break;
                    case 3:
                        team.add(new Swordsman(210, 40, 80, 40));
                        break;
                    case 4:
                        team.add(new Assassin(180, 30, 60, 90, 40));
                        break;
                    case 5:
                        team.add(new Archer(190, 35, 50, 100, 30));
                        break;
                    case 6:
                        team.add(new Mage(160, 20, 40, 90, 50));
                        break;
                }
            }
            return true;
        }
        #endregion
        #region Start
        /// <summary>
        /// Start button only shows once both players are logged in, this includes the team selection
        /// </summary>
        private void buttonStart()
        {
            // Check if both users are logged in
            if (user1 != null && user2 != null)
            {
                StartButton.Visible = true; // Show "Start Game" button
                StartButton.Enabled = true; // Makes the button "usable"
            }
            else
            {
                StartButton.Visible = false;
                StartButton.Enabled = false;
            }
        }
        /// <summary>
        /// Start Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //hide Menu
            this.Hide();
            // Create the BattleController and pass the necessary data
            this.Battle = new Controller(this.team1.team, this.team2.team, user1.username, user2.username);
            // Show the BattleView
            this.Battle.StartBattle();
            //show menu once battle is closed
            this.Show();
        }
        #endregion
        #region Edit team
        /// <summary>
        /// Edit current team + update SQL database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="i"></param>
        private void Edit_Button(object sender, EventArgs e, int i)
        {
            Team chooseTeam = new Team();
            chooseTeam.StartPosition = FormStartPosition.CenterScreen;
            chooseTeam.ShowDialog();
            if (chooseTeam.status)
            {

                if (i == 1)
                {
                    if (team1 != null)
                    {
                        team1 = null;
                    }
                    team1 = chooseTeam.SelectedTeam;
                    connection.UpdateTeam(team1, user1.username);
                    logShow(1);
                }
                if (i == 2)
                {
                    if (team2 != null)
                    {
                        team2 = null;
                    }
                    team2 = chooseTeam.SelectedTeam;
                    connection.UpdateTeam(team2, user2.username);
                    logShow(2);
                }
            }
        }
        #endregion
        #region scoreboard
        private void buttonScoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.StartPosition = FormStartPosition.CenterScreen;
            scoreboard.ShowDialog();
        }
        #endregion
    }
}