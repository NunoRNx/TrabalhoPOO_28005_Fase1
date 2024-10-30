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
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox_CheckedChanged;
            checkBox5.CheckedChanged += CheckBox_CheckedChanged;
            checkBox6.CheckedChanged += CheckBox_CheckedChanged;

            // Wire up the button click event
            button1.Click += (sender, e) => LogInOut(sender, e, 1);
            button2.Click += (sender, e) => LogInOut(sender, e, 2);
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
                        textBox1.Text = login.username;
                        textBox1.Visible = true;
                        /*listBox1.Visible = true;
                        listBox2.Visible = true;
                        listBox3.Visible = true;
                        button3.Visible = true;*/
                        button1.Text = "Logout";
                    }
                }
                else
                {
                    // Log out user1
                    user1 = null;

                    // Hide UI elements for player 1
                    textBox1.Visible = false;
                    listBox1.Visible = false;
                    listBox2.Visible = false;
                    listBox3.Visible = false;
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
                    listBox4.Visible = false;
                    listBox5.Visible = false;
                    listBox6.Visible = false;
                    button4.Visible = false;
                    button2.Text = "Login";
                }
            }

            // Check if both users are logged in
            buttonStart();
        }
        private void teamLists(string username)
        {
            BattleTeams teamList = null;
            string connectionString = "Server=DESKTOP-2J6JLCD\\SQLEXPRESS;Database=RPG;User Id=rpg_admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";

            // Query to fetch the password for the given username
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

                    // Execute the query and get the result
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    this.user1.userID = id;
                    query = "SELECT team_id, character1, character2, character3 FROM team_presets WHERE user_id = " + id;
                    using (SqlCommand team = new SqlCommand(query, connection))
                    {
                        // Define the parameter and add it to the command
                        object preset = team.ExecuteNonQuery();
                        //teamList = new BattleTeams();
                    }
                }
            }
            this.team1 = teamList;
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
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Get the currently checked checkbox count
            int checkedCount1 = 0;
            int checkedCount2 = 0;
            CheckBox[] checkboxes1 = { checkBox1, checkBox2, checkBox3 };
            CheckBox[] checkboxes2 = { checkBox4, checkBox5, checkBox6 };

            foreach (var checkbox in checkboxes1)
            {
                if (checkbox.Checked)
                {
                    checkedCount1++;
                }
            }
            foreach (var checkbox in checkboxes2)
            {
                if (checkbox.Checked)
                {
                    checkedCount1++;
                }
            }

            // If more than MaxTeamSize checkboxes are checked, uncheck the last one
            if (checkedCount1 > 1 || checkedCount2 > 1)
            {
                // Uncheck the checkbox that triggered the event if the limit is exceeded
                CheckBox currentCheckbox = sender as CheckBox;
                if (currentCheckbox != null)
                {
                    currentCheckbox.Checked = false;
                    MessageBox.Show($"You can only select one team for battle.");
                }
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

        private void button6_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.ShowDialog();
        }
    }
}
