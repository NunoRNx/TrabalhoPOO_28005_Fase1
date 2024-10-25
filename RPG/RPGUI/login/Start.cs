using RPGUI.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RPGUI
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

            // Wire up the button click event
            button1.Click += login;
            button2.Click += signUp;
        }

        private void login(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
        private void signUp(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }
    }
}
