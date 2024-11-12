namespace RPG
{
    /// <summary>
    /// All Classes that can be chosen
    /// </summary>
    #region Shields
    public class Warrior : Class
    {
        private int Rage { get; set; }

        public Warrior(int hp, int defense, int strength, int rage)
            : base("The Warrior", "Shield", hp, defense, strength, 100, 50)
        {
            this.Rage = rage;
        }

        public override int Attack()
        {
            this.Rage = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.strength * 1.2); // Basic attack with a bit more power
        }

        public override int Special()
        {
            int damage = (int)(this.strength * 1.5); // 50% stronger than normal
            this.Rage -= 20; // Consumes some rage
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.strength * 2.5);
            this.Rage = 0; // Consumes all rage
            return damage;
        }

        public override void Block()
        {
            this.Rage = RechargeGauge(8); // Recharge rage when blocking
            this.defense += 5; // Buffs defense temporarily for blocking stance
        }

        public override int GetGauge()
        {
            return this.Rage; // Return the current rage gauge value
        }
    }

    public class Paladin : Class
    {
        private int Holy { get; set; }

        public Paladin(int hp, int defense, int strength, int holy)
            : base("Holy Knight", "Shield", hp, defense, strength, 100, 50)
        {
            this.Holy = holy;
        }

        public override int Attack()
        {
            return (int)(this.strength * 1.1); // Less attack power but more balanced
        }

        public override int Special()
        {
            int damage = (int)(this.strength * 1.3 + Holy * 0.3); // Holy power influences special attack
            Holy -= 10; // Consumes some holy power
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.strength * 2 + Holy * 0.5);
            Holy = 0; // Consumes all holy power
            return damage;
        }

        public override void Block()
        {
            this.defense += 7;
        }

        public override int GetGauge()
        {
            return this.Holy; // Return the current holy power value
        }
    }
    #endregion

    #region Vanguard
    public class Swordsman : Class
    {
        private int Focus { get; set; }

        public Swordsman(int hp, int defense, int strength, int focus)
            : base("Sword Master", "Vanguard", hp, defense, strength, 100, 50)
        {
            this.Focus = focus;
        }

        public override int Attack()
        {
            this.Focus = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.strength * 1.3); // Strong attack
        }

        public override int Special()
        {
            int damage = (int)(this.strength * 1.7);
            this.Focus -= 20; // Consumes focus points
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.strength * 3.0);
            this.Focus = 0; // Consumes all focus points
            return damage;
        }

        public override void Block()
        {
            this.defense += 4;
        }

        public override int GetGauge()
        {
            return this.Focus; // Return the current focus value
        }
    }

    public class Assassin : Class
    {
        private int Stealth { get; set; }
        private int Dexterity { get; set; } // Only initialized here for Assassin

        public Assassin(int hp, int defense, int strength, int dexterity, int stealth)
            : base("Assassin", "Vanguard", hp, defense, strength, 100, 50)
        {
            this.Stealth = stealth;
            this.Dexterity = dexterity; // Only initialize dexterity here
        }

        public override int Attack()
        {
            this.Stealth = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.strength * 1.4); // Stronger attack
        }

        public override int Special()
        {
            int damage = (int)(this.strength * 1.2 + this.Dexterity * 0.5); // Dexterity influences damage
            this.Stealth -= 15; // Consumes stealth power
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.strength * 2.5 + this.Dexterity * 0.8); // Dexterity used in ultimate
            this.Stealth = 0; // Consumes all stealth power
            return damage;
        }

        public override void Block()
        {
            this.defense += 3;
        }

        public override int GetGauge()
        {
            return this.Stealth; // Return the current stealth power value
        }
    }
    #endregion

    #region Offensive
    public class Archer : Class
    {
        private int Arrows { get; set; }
        private int Dexterity { get; set; } // Only initialized here for Archer

        public Archer(int hp, int defense, int strength, int dexterity, int arrows)
            : base("The Arrow", "Offensive", hp, defense, strength, 100, 50)
        {
            this.Arrows = arrows;
            this.Dexterity = dexterity; // Only initialize dexterity here
        }

        public override int Attack()
        {
            this.Arrows = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.Dexterity * 1.5); // Dexterity-based attack
        }

        public override int Special()
        {
            int damage = (int)(this.Dexterity * 2.0);
            this.Arrows -= 2; // Consumes some arrows for special
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(this.Dexterity * 2.5);
            this.Arrows -= 5; // Drains significant arrows
            return damage;
        }

        public override void Block()
        {
            this.defense += 4;
        }

        public override int GetGauge()
        {
            return this.Arrows; // Return the current arrows value
        }
    }

    public class Mage : Class
    {
        private int Mana { get; set; }
        private int Magic { get; set; } // Only initialized here for Mage

        public Mage(int hp, int defense, int strength, int magic, int mana)
            : base("The Sage", "Offensive", hp, defense, strength, 100, 50)
        {
            this.Mana = mana;
            this.Magic = magic; // Only initialize magic here
        }

        public override int Attack()
        {
            this.Mana = RechargeGauge(10); // Recharge 10 points for basic attack
            return (int)(this.Magic * 1.1); // Basic attack using magic
        }

        public override int Special()
        {
            int damage = (int)(Magic * 1.7);
            this.Mana -= 20; // Consume mana for special
            return damage;
        }

        public override int Ultimate()
        {
            int damage = (int)(Magic * 3.0); // Ultimate consumes all mana
            this.Mana = 0;
            return damage;
        }

        public override void Block()
        {
            this.defense += 5;
        }

        public override int GetGauge()
        {
            return this.Mana; // Return the current mana value
        }
    }
    #endregion
}

//old classes
/*
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

            */

