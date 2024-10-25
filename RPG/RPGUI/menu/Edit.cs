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

namespace RPGUI.menu
{
    public partial class Edit : Form
    {
        Class[][] preset {  get; set; }
        public Edit(Class[][] presets)
        {
            preset = presets;
            InitializeComponent();
            button1.Click += (sender, e) => ChangeTeam(sender,e,0);
            button2.Click += (sender, e) => ChangeTeam(sender,e,1);
            button3.Click += (sender, e) => ChangeTeam(sender,e,2);
        }
        private void ChangeTeam(object sender, EventArgs e, int j)
        {
            Team chooseTeam = new Team();
            chooseTeam.ShowDialog();
            Class[] player = chooseTeam.SelectedTeam;
            for (int i = 0; i < player.Length; i++)
            {
                this.preset[i][j]= player[i];
            }
        }
    }
}
