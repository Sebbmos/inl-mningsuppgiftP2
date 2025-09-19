namespace inlämningsuppgift
// skapa rest metod ----- skapa en status visare ---- skapa en fight metod för karaktär contra fiender --------

{
    public class WorldHelper
    {
        //Rest för warrior
        public static void Rest(Warrior player)
        {
            player.HP += 30;
            if (player.HP > player.MaxHP)
            {
                player.HP = player.MaxHP;
            }

            Console.WriteLine("You look around you and realize that there is no one else in the room except you.");
            Console.WriteLine("You put down your weapon and find something that used to be a comfortable chair and rest for a while.");
            Console.WriteLine($"{player.Name} rests and recovers. Current HP: {player.HP}/{player.MaxHP}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        //Rest för Mage
        public static void Rest(Mage player)
        {
            player.HP += 30;
            if (player.HP > player.MaxHP)
            {
                player.HP = player.MaxHP;
            }

            Console.WriteLine("You look around you and realize that there is no one else in the room except you.");
            Console.WriteLine("You put down your weapon and find something that used to be a comfortable chair and rest for a while.");
            Console.WriteLine($"{player.Name} rests and recovers. Current HP: {player.HP}/{player.MaxHP}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }




        public static void StartGame(object player)
        {               // Start av spel och konflikt
            Console.Clear();
            Console.WriteLine("You open the door and step into the next room.\n");

            EnemiesCreator enemy = new EnemiesCreator();
            Console.WriteLine($"You see {enemy.EnemyName} infront of you!\n");
            Console.WriteLine($"{enemy.EnemyName} haves {enemy.EnemyHp}HP and {enemy.EnemyDamage} damage.\n");
            Console.WriteLine("What will you do now?");

            bool fight = true;
            while (fight)
            {                       //Fight med enemies
                Console.WriteLine("[1] Attack");
                Console.WriteLine("[2] Run");
                int choice = int.Parse(Console.ReadLine());
                //player attackerar
                if (choice == 1)
                {
                    if (player is Warrior w)
                    {
                        enemy.EnemyHp -= w.Damage;
                        Console.WriteLine($"{w.Name} hits {enemy.EnemyName} for {w.Damage}\n");
                        Console.WriteLine($"Enemy HP:{enemy.EnemyHp}\n");
                    }
                    else if (player is Mage m)
                    {
                        enemy.EnemyHp -= m.Damage;
                        Console.WriteLine($"{m.Name} cast a spell {enemy.EnemyName} for {m.Damage}\n");
                        Console.WriteLine($"Enemy HP:{enemy.EnemyHp}\n");
                    }

                    if (enemy.EnemyHp <= 0)
                    {
                        Console.WriteLine($"{enemy.EnemyName} was defeated! You looted {enemy.GoldReward} gold.\n");
                        if (player is Warrior w2) w2.Gold += enemy.GoldReward;
                        else if (player is Mage m2) m2.Gold += enemy.GoldReward;
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        fight = false;

                    }
                    else
                    {
                        if (player is Warrior w3)
                        {
                            w3.HP -= enemy.EnemyDamage;
                            Console.WriteLine($"{enemy.EnemyName} hits you for {enemy.EnemyDamage}!\n");
                            Console.WriteLine($"{w3.Name} HP:{w3.HP}\n");
                            if (w3.HP <= 0)
                            {
                                Console.WriteLine("You fell to the ground and there will your remains stay.");
                                Console.WriteLine("-------------------GAME OVER.---------------------------\n");
                                Console.WriteLine("Press any key");

                                Console.ReadKey();
                                Environment.Exit(0);
                            }

                        }
                        else if (player is Mage m3)
                        {
                            m3.HP -= enemy.EnemyDamage;
                            Console.WriteLine($"{enemy.EnemyName} hits you for {enemy.EnemyDamage}!\n");
                            Console.WriteLine($"{m3.Name} HP:{m3.HP}\n");
                            if (m3.HP <= 0)
                            {
                                Console.WriteLine("You fell to the ground and there will your remains stay.\n");
                                Console.WriteLine("GAME OVER.\n");
                                Console.WriteLine("Press any key");

                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                    }

                }                                       //PS. jag hatar else if 
                else if (choice == 2)
                {
                    Console.WriteLine("You turned your back and run back to the previous room.\n");
                    fight = false;
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }



        }

    }
}
