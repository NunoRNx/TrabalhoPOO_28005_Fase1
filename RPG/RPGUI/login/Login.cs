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
using RPGUI;


namespace RPGUI
{
    public partial class Login : Form
    {
        private User User { get; set; }
        public Login()
        {
            this.User = null;
            this.User = null;
            InitializeComponent();

            // Wire up the button click event
            button1.Click += login;
            linkLabel1.LinkClicked += sign;

        }
        public User user
        {
            get { return this.User; }
        }
        private void sign(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
        private void login(object sender, EventArgs e)
        {
            try
            {
                string? username = textBoxUser.Text;
                string? passwd = textBoxPass.Text;
                if (string.IsNullOrEmpty(username))
                {
                    //textBox1.Focus(); // Focus back on the username textbox if empty
                    throw new Exception("Make sure to fill the username.");
                }
                else if (string.IsNullOrEmpty(passwd))
                {
                    //textBox2.Focus(); // Focus back on the password textbox if empty
                    throw new Exception("Make sure to fill the password.");
                }
                else if (CheckLogin(username, passwd))
                {
                    // Login successful - proceed to the next step
                    int[] data = UserData(username);
                    this.User = new User(username, data[0], data[1]);
                    Close();
                }
                else
                {
                    //textBox1.Focus(); // Focus back on username for re-entry
                    throw new Exception("Password or Username incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool CheckLogin(string inputUsername, string inputPassword)
        {
            // Define your connection string (update with your server details)
            string connectionString = "Server=DESKTOP-2J6JLCD\\SQLEXPRESS;Database=RPG;User Id=rpg_admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";

            // Query to fetch the password for the given username
            string query = "SELECT password FROM user_info WHERE username = @username";

            // Use a SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Use a command with parameterized query to prevent SQL injection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the parameter and add it to the command
                    command.Parameters.AddWithValue("@username", inputUsername);

                    // Execute the query and get the result
                    object result = command.ExecuteScalar();

                    // Check if a matching username was found
                    if (result != null)
                    {
                        string storedPassword = result.ToString();

                        // Compare the input password with the stored password
                        return inputPassword == storedPassword;
                    }
                    else
                    {
                        // Username not found
                        return false;
                    }
                }
            }
        }
        public int[] UserData(string inputUsername)
        {
            int[] scoreboard = new int[2];
            // Define your connection string (update with your server details)
            string connectionString = "Server=DESKTOP-2J6JLCD\\SQLEXPRESS;Database=RPG;User Id=rpg_admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";

            // Query to fetch the password for the given username
            string query = "SELECT wins, matches FROM user_info WHERE username = @username";

            // Use a SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Use a command with parameterized query to prevent SQL injection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the parameter and add it to the command
                    command.Parameters.AddWithValue("@username", inputUsername);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())  // Checks if there’s at least one row in the result
                        {
                            scoreboard[0] = reader.GetInt32(0);  // Reads the 'wins' column
                            scoreboard[1] = reader.GetInt32(1);  // Reads the 'matches' column
                        }
                        else
                        {
                            throw new Exception("No record of this user exists in the database");
                        }
                    }
                }
            }
            return scoreboard;
        }
        private bool Click = true;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Click)
            {
                pictureBox2.Image = Properties.Resources.unlocked;
                textBoxPass.PasswordChar = '\0'; // Show password
                Click = false;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.locked;
                textBoxPass.PasswordChar = '*'; // Hide password
                Click = true;
            }
        }
    }
}
