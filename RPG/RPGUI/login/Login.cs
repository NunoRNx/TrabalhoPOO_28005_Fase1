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
        SQL database = SQL.Instance;
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
            // Open the SignUp form
            using (SignUp signUpForm = new SignUp())
            {
                this.Hide();
                signUpForm.StartPosition = FormStartPosition.CenterScreen;
                // Show the SignUp form as a dialog
                signUpForm.ShowDialog();
            }

            // Reopen the Login form after SignUp completes
            this.Show();
        }
        /// <summary>
        /// User login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (string.IsNullOrEmpty(passwd))
                {
                    //textBox2.Focus(); // Focus back on the password textbox if empty
                    throw new Exception("Make sure to fill the password.");
                }
                if (database.CheckLogin(username, passwd))
                {
                    // Login successful - proceed to the next step
                    int[] data = database.UserData(username);
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
        /// <summary>
        /// Password showing state
        /// </summary>
        private bool Click = true;
        /// <summary>
        /// Show Password method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
