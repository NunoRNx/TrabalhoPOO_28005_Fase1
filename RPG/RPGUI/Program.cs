using RPG;
using RPGUI.menu;
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
            start();
            menu();
            /*// Create and get the Team
            Class[] player1 = get_team(1);
            Class[] player2 = get_team(2);
            //battle(player1, player2);
            */
        }
        private static void start()
        {
            Start start = new Start();
            start.ShowDialog(); 
        }
        private static void menu()
        {
            Menu menu = new Menu();
            menu.ShowDialog();
            
        }

        private static Class[] get_team(int i)
        {
            Team chooseTeam = new Team();
            chooseTeam.ShowDialog();
            Class[] player = chooseTeam.SelectedTeam;
            MessageBox.Show($"Player {i} selected:\n{player[0].name}\n{player[1].name}\n{player[2].name}");
            return player;
        }
    }
}