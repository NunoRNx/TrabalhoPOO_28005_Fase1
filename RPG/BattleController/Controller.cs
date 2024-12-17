using BattleModel;
using BattleView;
using RPG;

namespace BattleController
{
    public class Controller
    {
        private Model model;
        private View view;

        public Controller(BattleTeams player1Team, BattleTeams player2Team, string user1, string user2)
        {
            this.model = new Model(player1Team, player2Team, user1, user2);
            this.view = new View();
        }

        public void StartBattle()
        {
            this.view.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.view.ShowDialog();
        }
    }
}
