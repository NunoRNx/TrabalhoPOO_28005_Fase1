using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

using System.Data;


namespace RPG
{
    /// <summary>
    /// Singleton SQL connection class
    /// </summary>
    public class SQL
    {
        private static SQL _instance;
        private string connection {  get; set; } 

        private SQL()
        {
            //desktop
            this.connection = "Server=DESKTOP-2J6JLCD\\SQLEXPRESS;Database=RPG;User Id=rpg_admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";

            //laptop
            //this.connection = "Server=...\\SQLEXPRESS02;Database=RPG;User Id=rpg_admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";
        }
        public static SQL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SQL(); // Lazy initialization
                }
                return _instance;
            }
        }

        
        #region login
        /// <summary>
        /// Verify if user is in the database
        /// </summary>
        /// <param name="inputUsername"></param>
        /// <param name="inputPassword"></param>
        /// <returns></returns>
        public bool CheckLogin(string inputUsername, string inputPassword)
        {
            // Query to fetch the password for the given username
            string query = "SELECT password FROM user_info WHERE username = @username";

            // Use a SQL connection
            using (SqlConnection connection = new SqlConnection(this.connection))
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
        #endregion
        #region Sign Up
        public bool CreateAcc(string username, string password)
        {

            // Query to fetch the password for the given username
            string query = "SELECT username FROM user_info WHERE username = @username";

            // Use a SQL connection
            using (SqlConnection connection = new SqlConnection(this.connection))
            {
                connection.Open();

                // Use a command with parameterized query to prevent SQL injection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the parameter and add it to the command
                    command.Parameters.AddWithValue("@username", username);

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
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@passwd", password);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    return false;
                }
            } 
        }

        #endregion
        #region User/Scoreboard info
        /// <summary>
        /// Retrive user_id from database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private int GetUserId(string username)
        {
            using (SqlConnection connection = new SqlConnection(this.connection))
            {
                connection.Open();
                string query = "SELECT user_id FROM user_info WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    return (int)command.ExecuteScalar();
                }
            }
        }
        /// <summary>
        /// Method that retrieves Game related information about the user, amout of wins and amount of matchs played
        /// </summary>
        /// <param name="inputUsername"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int[] UserData(string inputUsername)
        {
            int[] scoreboard = new int[2];
            
            // Query to fetch the password for the given username
            string query = "SELECT wins, matches FROM user_info WHERE username = @username";

            // Use a SQL connection
            using (SqlConnection connection = new SqlConnection(this.connection))
            {
                connection.Open();

                // Use a command with parameterized query to prevent SQL injection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the parameter and add it to the command
                    command.Parameters.AddWithValue("@username", inputUsername);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())  // Checks if there’s at least one row in the result
                        {
                            scoreboard[0] = reader.GetInt32(0);  // Reads the 'wins' column
                            scoreboard[1] = reader.GetInt32(1);  // Reads the 'matches' column
                        }
                        else
                        {
                            throw new Exception("No record of this user exists in the database");
                        }
                    }
                }
            }
            return scoreboard;
        }
        /// <summary>
        /// Load the scoreboard from SQL and return it to the windows forms to be displayed
        /// </summary>
        /// <returns></returns>
        public DataTable GetScoreboard()
        {

            string query = "SELECT username, wins, matches FROM user_info ORDER BY wins DESC";
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(this.connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception error)
            {
                // Handle the exception or log it
                throw error;
            }

            return dataTable;
        }
        #endregion
        #region Load/Insert Team preset
        public bool GetTeamData(string username, out int[] characters)
        {
            characters = new int[3];
            string query = "SELECT user_id FROM user_info WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(this.connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    int userId = Convert.ToInt32(command.ExecuteScalar());

                    string teamQuery = "SELECT character_id_1, character_id_2, character_id_3 FROM team_presets WHERE user_id = @userId";
                    using (SqlCommand teamCommand = new SqlCommand(teamQuery, connection))
                    {
                        teamCommand.Parameters.AddWithValue("@userId", userId);

                        using (SqlDataReader reader = teamCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                characters[0] = reader.GetInt32(0);
                                characters[1] = reader.GetInt32(1);
                                characters[2] = reader.GetInt32(2);
                            }
                            else
                            {
                                return false; // No team preset found
                            }
                        }
                    }
                }
            }
            return true;
        }
        
        /// <summary>
        /// For a new user without a team, insert into database the new team
        /// </summary>
        /// <param name="team"></param>
        /// <param name="username"></param>
        public void InsertTeam(BattleTeams team, string username)
        {
            int userId = GetUserId(username);
            using (SqlConnection connection = new SqlConnection(this.connection))
            {
                connection.Open();
                string query = "INSERT INTO team_presets (user_id, character_id_1, character_id_2, character_id_3) VALUES (@user_id, @character_id_1, @character_id_2, @character_id_3)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@character_id_1", team.team[0].id);
                    command.Parameters.AddWithValue("@character_id_2", team.team[1].id);
                    command.Parameters.AddWithValue("@character_id_3", team.team[2].id);

                    command.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Update team in SQL database
        /// </summary>
        /// <param name="team"></param>
        /// <param name="username"></param>
        public void UpdateTeam(BattleTeams team, string username)
        {
            int userId = GetUserId(username);
            using (SqlConnection connection = new SqlConnection(this.connection))
            {
                connection.Open();
                string query = "UPDATE team_presets SET character_id_1 = @character_id_1, character_id_2 = @character_id_2, character_id_3 = @character_id_3 WHERE user_id = @user_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@character_id_1", team.team[0].id);
                    command.Parameters.AddWithValue("@character_id_2", team.team[1].id);
                    command.Parameters.AddWithValue("@character_id_3", team.team[2].id);

                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region Update User info
        /// <summary>
        /// Increase the won matches counter of a user by 1
        /// </summary>
        /// <param name="username"> Username of player that won a match</param>
        public void IncreaseWin(string username)
        {
            using (SqlConnection connection = new SqlConnection(this.connection))
            {
                connection.Open();
                int wins;

                // Fetch the current wins count
                string query = "SELECT wins FROM user_info WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    wins = (int)command.ExecuteScalar();
                }

                // Update the wins count
                query = "UPDATE user_info SET wins = @wins WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@wins", wins + 1);
                    command.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Increase the match counter of a user by 1
        /// </summary>
        /// <param name="username"> Username of player that finished a match</param>
        public void IncreaseMatches(string username)
        {
            using (SqlConnection connection = new SqlConnection(this.connection))
            {
                connection.Open();
                int matches;

                // Fetch the current wins count
                string query = "SELECT wins FROM user_info WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    matches = (int)command.ExecuteScalar();
                }

                // Update the wins count
                query = "UPDATE user_info SET matches = @matches WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@matches", matches + 1);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
