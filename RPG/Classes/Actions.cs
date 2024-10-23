namespace RPG
{
    public class Actions
    {
        /// <summary>
        /// Action menu, all options a player can make witht the current character
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemyTeam"></param>
        public static void actions(Class player, Class[] enemyTeam)
        {
            int action = 0;
            do
            {
                Console.WriteLine("Character: "+player.name);
                Console.WriteLine("1-Basic Attack");
                Console.WriteLine("2-Special Attack");
                Console.WriteLine("3-Block");
                Console.WriteLine("4-Ability");
                Console.Write("Option: ");
                action = Convert.ToInt32(Console.ReadLine());
            } while (action < 1 || action > 4);
            switch (action)
            {
                case 1:
                    int i = -1;
                    do
                    {
                        Console.WriteLine("Enemy Team:");
                        displayTeam(enemyTeam);
                        i = select(enemyTeam);
                        if (i == -1)
                        {
                            Console.WriteLine("Charcter not found, try again\n");
                        }
                    } while (i != -1);

                    int damage = player.attack();
                    inflict(damage, enemyTeam[i]);
                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:
                    break;
            }
        }
        public static int select(Class[] team)
        {
            Console.Write("Charcter: ");
            string? name = Console.ReadLine();
            int j;
            for (int i = 0; i < team.Length; i++)
            {
                if (name.ToLower() == team[i].name.ToLower())
                {
                    j = i;
                    break;
                }
            }
            return -1;
        }
        /// <summary>
        /// Dice roll from minimum to maximum to affect the action of a player
        /// </summary>
        /// <returns></returns>
        public static int diceRoll(int min, int max)
        {
            Random rand = new Random();
            int roll = rand.Next(min, max);
            Console.WriteLine("You rolled a " + roll);
            return roll;
        }
        public static int crit(int damage)
        {
            //critical hit multiplier
            return 0;
        }
        public static int resistence(int damage)
        {
            //block multiplier
            return 0;
        }

        public static void inflict(int damage, Class enemy)
        {
            int critDamage = crit(damage);
            int finalDamage = resistence(critDamage);
            enemy.hp -= finalDamage;
            if (enemy.alive == false)
            {
                Console.WriteLine(enemy.name + " as been slain");
            }

        }
        public static void block(Class player)
        {
            int multiplier = diceRoll(11, 21);
            player.defense = (int)Math.Round(player.defense * (multiplier / 10.0));
        }
        /// <summary>
        /// reset defense stat for all charcters, after the use of block defense stat is altered for 1 round
        /// </summary>
        /// <param name="team"></param>
        /// <param name="max"></param>
        /// <returns>void</returns>
        public static void endRound(Class[] team, int max)
        {
            for (int i = 0; i < max; i++)
            {
                team[i].defense = team[i].originalDefense;
            }
        }

        /*public static void displayTeam(Class[] team)
        {
            for (int i = 0; i < team.Length; i++) 
            {
                Console.Write("\t"+team[i].name + "\t");
            }
            for (int i = 0; i < team.Length; i++) 
            {
                if (i == 0)
                {
                    Console.Write("Health:    ");
                }
                if (team[i].alive)
                {
                    Console.Write(team[i].hp + "\t");
                }
            }
            for (int i = 0; i < team.Length; i++) 
            {
                if (i == 0)
                {
                    Console.Write("Defense:   ");
                }
                if (team[i].alive)
                {
                    Console.Write(team[i].defense + "\t");
                }
            }
            for (int i = 0; i < team.Length; i++) 
            {
                if (i == 0)
                {
                    Console.Write("Streght:   ");
                }
                if (team[i].alive)
                {
                    Console.Write(team[i].streght + "\t");
                }
            }
            for (int i = 0; i < team.Length; i++) 
            {
                if (i == 0)
                {
                    Console.Write("Dexterity: ");
                }
                if (team[i].alive)
                {
                    Console.Write(team[i].dexterity + "\t");
                }
            }
            for (int i = 0; i < team.Length; i++) 
            {
                if (i == 0)
                {
                    Console.Write("Stamina:   ");
                }
                if (team[i].alive)
                {
                    Console.Write(team[i].stamina + "\t");
                }
            }
            for (int i = 0; i < team.Length; i++) 
            {
                if (i == 0)
                {
                    Console.Write("Magic:     ");
                }
                if (team[i].alive)
                {
                    Console.Write(team[i].magic + "\t");
                }
            }
            for (int i = 0; i < team.Length; i++) 
            {
                if (i == 0)
                {
                    Console.Write("Status:    ");
                }
                if (team[i].alive)
                {
                    Console.Write("alive\t");
                }
                else
                {
                    Console.Write("dead\t");
                }
            }
        }*/

        public static void displayTeam(Class[] team)
        {
            for (int i = 0; i < team.Length; i++)
            {
                Console.WriteLine("Name: " + team[i].name);
                if (team[i].alive)
                {
                    Console.WriteLine("Type: " + team[i].type);
                    Console.WriteLine("Health: " + team[i].hp);
                    Console.WriteLine("Defense: " + team[i].defense);
                    Console.WriteLine("Streght: " + team[i].streght);
                    Console.WriteLine("Dexterity: " + team[i].dexterity);
                    Console.WriteLine("Stamina: " + team[i].stamina);
                    Console.WriteLine("Magic: " + team[i].magic);
                    Console.WriteLine("Status: alive" );
                    if (team[i] is Warrior warrior)
                    {
                        Console.WriteLine($"Rage: {warrior.rage}/{warrior.cost}");
                    }
                    if (team[i] is Paladin paladin)
                    {
                        Console.WriteLine($"Holy: {paladin.holy}/{paladin.cost}");
                    }
                    if (team[i] is Swordsman sword)
                    {
                        Console.WriteLine($"Focus: {sword.focus}/{sword.cost}");
                    }
                    if (team[i] is Assassin assassin)
                    {
                        Console.WriteLine($"Stealth: {assassin.stealth}/{assassin.cost}");
                    }
                    if (team[i] is Archer archer)
                    {
                        Console.WriteLine($"Arrows: {archer.arrows}/{archer.cost}");
                    }
                    if (team[i] is Mage mage)
                    {
                        Console.WriteLine($"Mana: {mage.mana}/{mage.cost}");
                    }
                }
                else
                {
                    Console.WriteLine("Status: dead");
                }
            }
        }
    }
}
