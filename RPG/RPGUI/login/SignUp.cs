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
using Microsoft.IdentityModel.Tokens;

namespace RPGUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            //open form
            InitializeComponent();
            SetText(textBoxUser, "username");
            SetPass(textBoxPass, "password");
            SetPass(textBoxConfirm, "confirm password");

            button1.Click += createAccount;

            //username textbox
            textBoxUser.Enter += (sender, e) => RemoveText(textBoxUser, "username");
            textBoxUser.Leave += (sender, e) => SetText(textBoxUser, "username");
            //password textbox
            textBoxPass.Enter += (sender, e) => RemovePass(textBoxPass, "password");
            textBoxPass.Leave += (sender, e) => SetPass(textBoxPass, "password");
            //password textbox
            textBoxConfirm.Enter += (sender, e) => RemovePass(textBoxConfirm, "confirm password");
            textBoxConfirm.Leave += (sender, e) => SetPass(textBoxConfirm, "confirm password");
        }
        private void SetText(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray; // Set the placeholder text color to gray
            }
        }

        private void RemoveText(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = ""; // Clear the placeholder text
                textBox.ForeColor = Color.Black; // Change text color to default
            }
        }
        private void SetPass(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
                textBox.PasswordChar = '\0'; // Show text instead of hiding characters
            }
        }
        private void RemovePass(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.PasswordChar = '*'; // Mask the password with '*'
            }
        }
        private void createAccount(object sender, EventArgs e)
        {
            try
            {
                // Check if the username and password fields are empty
                if (string.IsNullOrWhiteSpace(textBoxUser.Text) || string.IsNullOrWhiteSpace(textBoxPass.Text) || string.IsNullOrWhiteSpace(textBoxConfirm.Text))
                {
                    throw new ArgumentNullException("Make sure to fill the username and password boxes.");
                }
                // Check if the passwords match
                else if (textBoxPass.Text != textBoxConfirm.Text)
                {
                    throw new Exception("Make sure the passwords match");
                }
                SQL db_conn = SQL.Instance;
                if(db_conn.CreateAcc(textBoxUser.Text, textBoxConfirm.Text))
                {
                    MessageBox.Show("Account created successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create account.");
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
                if (textBoxPass.ForeColor != Color.Gray)
                {
                    textBoxPass.PasswordChar = '*'; // Hide password
                }
                Click = true;
            }
        }
    }
}
