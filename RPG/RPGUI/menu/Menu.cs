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
        public Menu()
        {
            //get data sql login.username

            InitializeComponent();

            //WRITE CONTENT INTO TEXTBOXES NUNOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

            // Subscribe to the CheckedChanged event for each checkbox
            /*checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox_CheckedChanged;
            checkBox5.CheckedChanged += CheckBox_CheckedChanged;
            checkBox6.CheckedChanged += CheckBox_CheckedChanged;*/

            // Wire up the button click event
            //loggin / logout
            button1.Click += (sender, e) => LogInOut(sender, e, 1);
            button2.Click += (sender, e) => LogInOut(sender, e, 2);
            //edit teams
            button3.Click += (sender, e) => Edit_Button(sender, e, 1);
            button4.Click += (sender, e) => Edit_Button(sender, e, 2);
        }
        private void LogInOut(object sender, EventArgs e, int i)
        {
            if (i == 1)
            {
                if (user1 == null || !user1.loggedIn) // Check if user1 is null or not logged in
                {
                    Login login = new Login();
                    login.ShowDialog();
                    if (!login.username.IsNullOrEmpty())
                    {
                        user1 = new User(login.username, 0, 0);
                        user1.loggedIn = true; // Ensure loggedIn is set to true when logging in

                        // Show UI elements for player 1
                        textBoxUser1.Text = login.username;
                        textBoxUser1.Visible = true;
                        //fetch team and display it
                        TeamLoad(login.username);
                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        button1.Text = "Logout";
                    }
                }
                else
                {
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
                }
            }
            else if (i == 2)
            {
                if (user2 == null || !user2.loggedIn) // Check if user2 is null or not logged in
                {
                    Login login = new Login();
                    login.ShowDialog();
                    if (!login.username.IsNullOrEmpty())
                    {
                        user2 = new User(login.username, 0, 0);
                        user2.loggedIn = true; // Ensure loggedIn is set to true when logging in

                        // Show UI elements for player 2
                        textBox2.Visible = true;
                        /*listBox4.Visible = true;
                        listBox5.Visible = true;
                        listBox6.Visible = true;
                        button4.Visible = true;*/
                        button2.Text = "Logout";
                    }
                }
                else
                {
                    // Log out user2
                    user2 = null;

                    // Hide UI elements for player 2
                    textBox2.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    button4.Visible = false;
                    button2.Text = "Login";
                }
            }

            // Check if both users are logged in
            buttonStart();
        }
        private PictureBox BoxImage(Class character, PictureBox pic)
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
        private BattleTeams TeamLoad(string username)
        {
            BattleTeams teamList = null;
            int[] characters = new int[3]; // Array to store character IDs

            string connectionString = "Server=DESKTOP-2J6JLCD\\SQLEXPRESS;Database=RPG;User Id=rpg_admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";

            // Query to fetch the user_id for the given username
            string query = "SELECT user_id FROM user_info WHERE username = @username";

            // Use a SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Use a command with parameterized query to prevent SQL injection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the parameter and add it to the command
                    command.Parameters.AddWithValue("@username", username);

                    // Execute the query and get the user ID
                    int userId = Convert.ToInt32(command.ExecuteScalar());

                    // Now fetch the team preset for this user ID
                    string teamQuery = "SELECT character1, character2, character3 FROM team_presets WHERE user_id = @userId";
                    using (SqlCommand teamCommand = new SqlCommand(teamQuery, connection))
                    {
                        // Use parameterized query
                        teamCommand.Parameters.AddWithValue("@userId", userId);

                        // Execute reader to get the characters
                        using (SqlDataReader reader = teamCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Read each character column into the array
                                characters[0] = reader.GetInt32(0); // character1
                                characters[1] = reader.GetInt32(1); // character2
                                characters[2] = reader.GetInt32(2); // character3
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < characters.Length; i++)
            {
                switch (characters[i])
                {
                    case 1:
                        //create warrior
                        break;
                    case 2:
                        //create paladin
                        break;
                    case 3:
                        //create swordsman
                        break;
                    case 4:
                        //create Assassin
                        break;
                    case 5:
                        //create archer
                        break;
                    case 6:
                        //create mage
                        break;
                }
            }
            return teamList;
        }
        private void buttonStart()
        {
            // Check if both users are logged in
            if (user1?.loggedIn == true && user2?.loggedIn == true)
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
            }
            if (i == 2)
            {
                // Pass player1 data to the Edit form
                Edit editForm = new Edit(team2);
                editForm.ShowDialog(); // Or use Show() depending on your need
            }
        }

        private void buttonScoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.ShowDialog();
        }
    }
}
