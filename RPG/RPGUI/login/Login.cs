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
        private string Username { get; set; }
        public Login()
        {
            InitializeComponent();

            // Wire up the button click event
            button1.Click += login;
            button2.Click += sign;

        }
        public string username
        {
            get { return this.Username; }
            set { this.Username = value; }
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
                string? username = textBox2.Text;
                string? passwd = textBox4.Text;
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
                    this.username = username;
                    Close();
                    return;
                }
                else
                {
                    //textBox1.Focus(); // Focus back on username for re-entry
                    throw new Exception("Password or Username incorrect.");
                }
            }
            catch (Exception ex)
            {
                textBox5.Text = ex.Message;
                textBox5.Visible = true;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = '\0'; // Show password
            }
            else
            {
                textBox4.PasswordChar = '*'; // Hide password
            }
        }
    }

}
