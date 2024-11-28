using RPG;
namespace RPGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SQL db_connection = SQL.Instance;
            Application.Run(new Menu());
        }

        private static BattleTeams get_team(int i)
        {
            Team chooseTeam = new Team();
            chooseTeam.ShowDialog();
            BattleTeams player = chooseTeam.SelectedTeam;
            MessageBox.Show($"Player {i} selected:\n{player.team[0].name}\n{player.team[1].name}\n{player.team[2].name}");
            return player;
        }
    }
}