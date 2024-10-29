using RPG;
using RPGUI.menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGUI
{
    public partial class Menu : Form
    {
        private User user1 {  get; set; }
        private User user2 {  get; set; }
        private Class[][] player1 { get; set; }
        private Class[][] player2 { get; set; }
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
            button1.Click += LogInOut;
            /*button1.Click += LogInOut;
            button1.Click += Edit_Button;
            button1.Click += Edit_Button;*/
        }
        private static void LogInOut(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

        }
        /*private static User getUser(string username)
        {
            User user = new User();
            return;
        }*/
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
        private void Edit_Button(object sender, EventArgs e)
        {
            // Pass player1 data to the Edit form
            Edit editForm = new Edit(player1);
            editForm.ShowDialog(); // Or use Show() depending on your need
        }
    }
}
