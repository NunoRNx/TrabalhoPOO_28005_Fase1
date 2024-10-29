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
    /*public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            try
            {
                button1.Click += createAccount;
            }catch(ArgumentNullException ex)
            {
                textBox8.Text = ex.Message;
                textBox8.Visible = true;
            }
            catch(ArgumentException ex)
            {
                textBox7.Text = ex.Message;
                textBox7.Visible = true;
            }
            catch (Exception ex)
            {
                textBox8.Text = ex.Message;
                textBox8.Visible = true;
            }
            
        }
        private void createAccount(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text == "")
            {
                throw new ArgumentNullException("Make sure to fill the username and password boxes.");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                throw new Exception("Make sure the passwords match");
            }
            // Define your connection string (update with your server details)
            string connectionString = "Server=DESKTOP-2J6JLCD\\SQLEXPRESS;Database=RPG;User Id=rpg_admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";

            // Query to fetch the password for the given username
            string query = "SELECT username FROM user_info WHERE username = @username";

            // Use a SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Use a command with parameterized query to prevent SQL injection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the parameter and add it to the command
                    command.Parameters.AddWithValue("@username", textBox1.Text);

                    // Execute the query and get the result
                    object result = command.ExecuteScalar();

                    // Check if a matching username was found
                    if (result == null)
                    {
                        throw new ArgumentException("Username already exists");
                    }
                    else
                    {
                        // Username not found
                        query = "INSERT INTO user_info ('@username','@passwd')";
                        SqlCommand insert = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", textBox1.Text);
                        command.Parameters.AddWithValue("@passwd", textBox2.Text);
                        result = command.ExecuteNonQuery();
                    }
                }
            }
        }
    }*/
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            button1.Click += createAccount;
        }
    
        private void createAccount(object sender, EventArgs e)
        {
            try
            {
                // Check if the username and password fields are empty
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    throw new ArgumentNullException("Make sure to fill the username and password boxes.");
                }
                // Check if the passwords match
                else if (textBox2.Text != textBox6.Text)
                {
                    throw new Exception("Make sure the passwords match");
                }
    
                // Define your connection string (update with your server details)
                string connectionString = "Server=DESKTOP-2J6JLCD\\SQLEXPRESS;Database=RPG;User Id=rpg_admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";
    
                // Query to fetch the password for the given username
                string query = "SELECT username FROM user_info WHERE username = @username";
    
                // Use a SQL connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
    
                    // Use a command with parameterized query to prevent SQL injection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Define the parameter and add it to the command
                        command.Parameters.AddWithValue("@username", textBox1.Text);
    
                        // Execute the query and get the result
                        object result = command.ExecuteScalar();
    
                        // Check if a matching username was found
                        if (result != null)
                        {
                            throw new ArgumentException("Username already exists");
                        }
                    }
    
                    // If the username is not found, insert the new account
                    string insertQuery = "INSERT INTO user_info (username, password) VALUES (@username, @passwd)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@username", textBox1.Text);
                        insertCommand.Parameters.AddWithValue("@passwd", textBox2.Text);
    
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create account.");
                        }
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
