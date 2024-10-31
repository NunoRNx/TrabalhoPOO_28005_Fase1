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
            menu();
            /*// Create and get the Team
            Class[] player1 = get_team(1);
            Class[] player2 = get_team(2);
            //battle(player1, player2);
            */
        }
        private static void menu()
        {
            Menu menu = new Menu();
            menu.ShowDialog();
            
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