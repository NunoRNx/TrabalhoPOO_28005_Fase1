using RPG;

namespace BattleView
{
    public partial class View : Form
    {
        public int player1=0;
        public int player2=0;
        public List<string> battleLog = new List<string>();

        public event Action Update;
        public event Action AttackButton;
        public event Action SpecialButton;
        public event Action UltimateButton;
        public event Action BlockButton;
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
        private void Select(object sender, EventArgs e, PictureBox pic, int player)
        {
            //clear current selection
            if (player == 1 && this.player1 != 0)
            {
                ClearSelection(player);
            }else if (player == 2 && this.player2 != 0)
            {
                ClearSelection(player);
            }
            
            PictureBox[] team=null;
            PictureBox[] selected=null;
            
            if (player == 1)
            {
                team = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3 };
                selected = new PictureBox[]{ arrow1, arrow2, arrow3 };

            }
            else if (player == 2)
            {
                team = new PictureBox[]{ pictureBox4, pictureBox5, pictureBox6 };
                selected = new PictureBox[]{ arrow4, arrow5, arrow6 };
            }
            for (int i = 0; i < 3; i++)
            {
                if (pic == team[i])
                {
                    if (player == 1)
                    {
                        this.player1 = i + 1;
                    }
                    else
                    {
                        this.player2 = i + 1;
                    }
                    selected[i].Visible = true;
                }
            }
        }
        private void ClearSelection(int player)
        {
           PictureBox[] pics = null;
           if (player == 1)
           {
               pics = new PictureBox[] { arrow1, arrow2, arrow3 };
           }
           else if (player == 2)
           {
               pics = new PictureBox[] { arrow4, arrow5, arrow6 };
           }
           foreach(PictureBox p in pics)
            {
                p.Visible = false;
            }
        }
        #endregion
        #region Event Action Buttons
        private void AttackButton_Click(object sender, EventArgs e)
        {
            AttackButton?.Invoke();
            LogBox.DataSource = battleLog;
        }
        private void SpecialButton_Click(object sender, EventArgs e)
        {
            SpecialButton?.Invoke();
            LogBox.DataSource = battleLog;
        }
        private void UltimateButton_Click(object sender, EventArgs e)
        {
            UltimateButton?.Invoke();
            LogBox.DataSource = battleLog;
        }
        private void BlockButton_Click(object sender, EventArgs e)
        {
            UltimateButton?.Invoke();
            LogBox.DataSource = battleLog;
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
        }
        private void CharacterName(List<Class> team, TextBox[] text)
        {
            for (int i = 0; i < team.Count; i++)
            {
                text[i].Text = team[i].name;
            }
        }
        public void UpdateHP(List<Class> team1, List<Class> team2)
        {
            TextBox[] HPTeam1 = { textBoxHP1, textBoxHP2, textBoxHP3 };
            TextBox[] HPTeam2 = { textBoxHP4, textBoxHP5, textBoxHP6 };
            CharacterHP(team1, HPTeam1);
            CharacterHP(team2, HPTeam2);
        }
        private void CharacterHP(List<Class> team, TextBox[] text)
        {
            for (int i = 0; i < team.Count; i++)
            {
                text[i].Text = "HP: "+ team[i].hp + "/" + team[i].maxHP;
            }
        }
        #endregion
    }
}
