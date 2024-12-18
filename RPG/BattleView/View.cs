using RPG;

namespace BattleView
{
    public partial class View : Form
    {
        public int player1=-1;
        public int player2=-1;
        public List<string> battleLog = new List<string>();
        public int roundCount;
        public event Action Update;
        public event Action AttackButton;
        public event Action SpecialButton;
        public event Action UltimateButton;
        public event Action BlockButton;

        public List<Class> team1;
        public List<Class> team2;

        public View()
        {
            InitializeComponent();
            this.Shown += Start;
            Attack.Click += AttackButton_Click;
            Special.Click += SpecialButton_Click;
            Ultimate.Click += UltimateButton_Click;
            Block.Click += BlockButton_Click;
            //charcter selection
            pictureBox1.Click += (s, e) => Select(s, e, pictureBox1, 1);
            pictureBox2.Click += (s, e) => Select(s, e, pictureBox2, 1);
            pictureBox3.Click += (s, e) => Select(s, e, pictureBox3, 1);
            pictureBox4.Click += (s, e) => Select(s, e, pictureBox4, 2);
            pictureBox5.Click += (s, e) => Select(s, e, pictureBox5, 2);
            pictureBox6.Click += (s, e) => Select(s, e, pictureBox6, 2);
        }
        #region Selection
        private void Select(object sender, EventArgs e, PictureBox pic, int team)
        {
            //clear current selection
            ClearSelection(team);
            
            PictureBox[] teamPic=null;
            PictureBox[] selected=null;
            
            if (team == 1)
            {
                teamPic = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3 };
                selected = new PictureBox[]{ arrow1, arrow2, arrow3 };
            }
            else if (team == 2)
            {
                teamPic = new PictureBox[]{ pictureBox4, pictureBox5, pictureBox6 };
                selected = new PictureBox[]{ arrow4, arrow5, arrow6 };
            }
            for (int i = 0; i < 3; i++)
            {
                if (pic == teamPic[i])
                {
                    if (team == 1)
                    {
                        if (team1[i].alive)
                        {
                            this.player1 = i;
                            selected[i].Visible = true;
                        }
                    }
                    else
                    {
                        if (team2[i].alive)
                        {
                            this.player2 = i;
                            selected[i].Visible = true;
                        }
                    }
                }
            }
            EnabledActions();
        }
        public void ClearSelection(int team)
        {
           PictureBox[] pics = null;
           if (team == 1)
           {
               pics = new PictureBox[] { arrow1, arrow2, arrow3 };
               this.player1 = -1;
           }
           else if (team == 2)
           {
               pics = new PictureBox[] { arrow4, arrow5, arrow6 };
               this.player2 = -1;
           }
           foreach(PictureBox p in pics)
           {
               p.Visible = false;
           }
           DisableActions();
        }
        #endregion
        #region Event Action Buttons
        private void EnabledActions()
        {
            if(this.player1 != -1 && this.player2 != -1)
            {
                Attack.Enabled = true;
                Special.Enabled = true;
                Ultimate.Enabled = true;
                Block.Enabled = true;
            }
        }
        private void DisableActions()
        {
            Attack.Enabled = false;
            Special.Enabled = false;
            Ultimate.Enabled = false;
            Block.Enabled = false;
        }
        private void AttackButton_Click(object sender, EventArgs e)
        {
            AttackButton?.Invoke();
        }
        private void SpecialButton_Click(object sender, EventArgs e)
        {
            SpecialButton?.Invoke();
        }
        private void UltimateButton_Click(object sender, EventArgs e)
        {
            UltimateButton?.Invoke();
        }
        private void BlockButton_Click(object sender, EventArgs e)
        {
            UltimateButton?.Invoke();
        }
        #endregion
        #region Start Loading
        private void Start(object sender, EventArgs e)
        {
            Update?.Invoke();
        }
        #endregion
        #region Update
        public void UpdatePic(List<Class> team1, List<Class> team2)
        {
            PictureBox[] picTeam1 = { pictureBox1, pictureBox2, pictureBox3 };
            PictureBox[] picTeam2 = { pictureBox4, pictureBox5, pictureBox6 };
            CharacterPic(team1, picTeam1);
            CharacterPic(team2, picTeam2);
        }
        private void CharacterPic(List<Class> team, PictureBox[] pic)
        {
            for (int i = 0; i < team.Count; i++)
            {
                switch (team[i].id)
                {
                    case 1:
                        pic[i].Image = Properties.Resources.Warrior;
                        break;
                    case 2:
                        pic[i].Image = Properties.Resources.paladin;
                        break;
                    case 3:
                        pic[i].Image = Properties.Resources.sword;
                        break;
                    case 4:
                        pic[i].Image = Properties.Resources.assassin;
                        break;
                    case 5:
                        pic[i].Image = Properties.Resources.archer;
                        break;
                    case 6:
                        pic[i].Image = Properties.Resources.sage;
                        break;
                }
            }
        }
        /// <summary>
        /// Update TextBox with the names
        /// </summary>
        /// <param name="team1"></param>
        /// <param name="team2"></param>
        public void UpdateText(string username1, string username2, List<Class> team1, List<Class> team2)
        {
            textBoxUser1.Text = username1;
            textBoxUser2.Text = username2;
            TextBox[] NamesTeam1 = { textBox1, textBox2, textBox3 };
            TextBox[] NamesTeam2 = { textBox4, textBox5, textBox6 };
            CharacterName(team1, NamesTeam1);
            CharacterName(team2, NamesTeam2);
            textPlayerTurn.Text = username1 + "'s turn";
        }
        private void CharacterName(List<Class> team, TextBox[] text)
        {
            for (int i = 0; i < team.Count; i++)
            {
                text[i].Text = team[i].name;
            }
        }
        public void UpdateHP(List<Class> team1, List<Class> team2, string playerTurn)
        {
            TextBox[] HPTeam1 = { textBoxHP1, textBoxHP2, textBoxHP3 };
            TextBox[] HPTeam2 = { textBoxHP4, textBoxHP5, textBoxHP6 };
            CharacterHP(team1, HPTeam1);
            CharacterHP(team2, HPTeam2);
            textRound.Text = $"Round: {roundCount}";
            if (roundCount > 1)
            {
                textPlayerTurn.Text = playerTurn + "'s turn";
            }
            LogBox.DataSource = battleLog;
            ClearSelection(1);
            ClearSelection(2);
            this.roundCount++;
        }
        private void CharacterHP(List<Class> team, TextBox[] text)
        {
            for (int i = 0; i < team.Count; i++)
            {
                if (team[i].alive)
                {
                    text[i].Text = "HP: " + team[i].hp + "/" + team[i].maxHP;
                }
                else
                {
                    text[i].BackColor = Color.Red;
                    text[i].Text = "Dead";
                }
            }
        }
        #endregion
        #region End Game
        public void EndGame(string winner)
        {
            MessageBox.Show(winner + " won!!");
            this.Close();
        }
        #endregion
    }
}
