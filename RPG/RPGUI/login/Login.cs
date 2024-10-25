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
    public partial class Login : Form
    {
        private User user {  get; set; }
        public Login()
        {
            InitializeComponent();

            // Wire up the button click event
            string username=textBox1.Text;
            string passwd=textBox2.Text;
            try
            {
                button1.Click += (sender, e) => login(sender, e, username, passwd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void login(object sender, EventArgs e, string username, string passwd)
        {
            if(username is null || passwd is null)
            {
                throw new ArgumentNullException("Make sure to fill the username and password.");
            }
            else
            {

            }
        }
    }
    
}
