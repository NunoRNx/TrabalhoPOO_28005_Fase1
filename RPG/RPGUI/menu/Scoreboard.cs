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
            // Connection string to the SQL database (replace with your actual connection string)
            string connectionString = "Server=DESKTOP-2J6JLCD\\SQLEXPRESS;Database=RPG;User Id=rpg_admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";

            // SQL query to fetch the scoreboard ordered by highest wins
            string query = "SELECT username, wins, matches FROM user_info ORDER BY wins DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
