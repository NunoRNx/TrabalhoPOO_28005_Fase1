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
using RPG;

namespace RPGUI
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
            LoadScoreboard();
        }
        private void LoadScoreboard()
        {
            try
            {
                SQL db_connection = SQL.Instance;
                // Get the scoreboard data from the SQL class
                DataTable scoreboardData = db_connection.GetScoreboard();

                dataGridView1.DataSource = scoreboardData;
                
                // Optionally, add the DataGridView to the form's controls if it is not already
                Controls.Add(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
