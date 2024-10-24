namespace RPG
{
    /// <summary>
    /// All Classes that can be choosen
    /// </summary>
    #region SubClasses

        #region Shields
        public class Warrior: Class
        {
            private int Rage { get; set; }

            public Warrior(int hp, int defense, int streght, int dexterity, int stamina, int magic, int rage)
                :base("The Warrior", "Shield", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Rage = rage;
            }

            public int rage
            {
                get { return this.Rage; }
                set { this.Rage = value; }
            }
            public override int attack()
            {
                //attack damage for each class
                return 0;
            }
            public override int special()
            {
                //attack damage for each class
                return 0;
            }
    }
        public class Paladin: Class
        {
            private int Holy { get; set; }

            public Paladin(int hp, int defense, int streght, int dexterity, int stamina, int magic, int holy)
                :base("Holy Knight", "Shield", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Holy = holy;
            }

            public int holy
            {
                get { return this.Holy; }
                set { this.Holy = value; }
            }
            public override int attack()
            {
                //attack damage for each class
                return 0;
            }
            public override int special()
            {
                //attack damage for each class
                return 0;
            }
        }
        #endregion

        #region Vanguard
        public class Swordsman: Class
        {
            private int Focus { get; set; }

            public Swordsman(int hp, int defense, int streght, int dexterity, int stamina, int magic, int focus)
                :base("Sword Master", "Vanguard", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Focus = focus;
            }

            public int focus
            {
                get { return this.Focus; }
                set { this.Focus = value; }
            }
            public override int attack()
            {
                //attack damage for each class
                return 0;
            }
            public override int special()
            {
                //attack damage for each class
                return 0;
            }
        }
        public class Assassin: Class
        {
            private int Stealth { get; set; }

            public Assassin(int hp, int defense, int streght, int dexterity, int stamina, int magic, int stealth)
                :base("Assassin", "Vanguard", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Stealth = stealth;
            }

            public int stealth
            {
                get { return this.Stealth; }
                set { this.Stealth = value; }
            }
            public override int attack()
            {
                //attack damage for each class
                return 0;
            }
            public override int special()
            {
                //attack damage for each class
                return 0;
            }
        }
        #endregion

        #region Ofensive
        public class Archer : Class
        {
            private int Arrows { get; set; }

            public Archer(int hp, int defense, int streght, int dexterity, int stamina, int magic, int arrows)
                : base("The Green Arrow", "Ofensive", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Arrows = arrows;
            }

            public int arrows
            {
                get { return this.Arrows; }
                set { this.Arrows = value; }
            }
            public override int attack()
            {
                //attack damage for each class
                return 0;
            }
            public override int special()
            {
                //attack damage for each class
                return 0;
            }
        }
        public class Mage : Class
        {
            private int Mana { get; set; }

            public Mage(int hp, int defense, int streght, int dexterity, int stamina, int magic, int mana)
                : base("The Sage", "Ofensive", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Mana = mana;
            }

            public int mana
            {
                get { return this.Mana; }
                set { this.Mana = value; }
            }
            public override int attack()
            {
                //attack damage for each class
                return 0;
            }
            public override int special()
            {
                //attack damage for each class
                return 0;
            }
        }
        #endregion

        #endregion
}
