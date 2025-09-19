namespace inlämningsuppgift
{
    public class Program
    {


        static void Main(string[] args)
        { //starta karaktär och välja klass

            string classChoice;
            string playername;
            object player = null;

            Console.WriteLine("Welcome, State your name");
            playername = Console.ReadLine().ToLower();

            Console.WriteLine($"{playername} what is your school of war? Warrior or Mage?");
            classChoice = Console.ReadLine().ToLower();

            if (classChoice == "warrior")
            {
                player = Character_Creation.CreateWarrior(playername);
                Console.WriteLine("You went to the taverna to drink some ale. Then everything goes dark.");
                Console.WriteLine("When you wake up you see that you are in a damped room with only a wooden door infront of you.");
                Console.WriteLine("How did i get here? goes trough your mind. But something is for sure. That door is one step closer to getting out.\n ");

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            else if (classChoice == "mage")
            {
                player = Character_Creation.CreateMage(playername);
                Console.WriteLine("You went to the taverna to drink some ale. Then everything goes dark.");
                Console.WriteLine("When you wake up you see that you are in a damped room with only a wooden door infront of you.");
                Console.WriteLine("How did i get here? goes trough your mind. But something is for sure. That door is one step closer to getting out.\n ");

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid choice. You will be defaulted to warrior.");
                player = Character_Creation.CreateWarrior(playername);
                Console.WriteLine("You went to the taverna to drink some ale. Then everything goes dark.");
                Console.WriteLine("When you wake up you see that you are in a damped room with only a wooden door infront of you.");
                Console.WriteLine("How did i get here? goes trough your mind. But something is for sure. That door is one step closer to getting out.\n ");

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }



            bool running = true;
            while (running)
            {

                Console.Clear();
                Console.WriteLine("----- DUNGEON ESCAPE ------");
                Console.WriteLine("[1] Open the door.");
                Console.WriteLine("[2] Rest for a bit. While you can.");
                Console.WriteLine("[3] Show status.");
                Console.WriteLine("[4] Stay in the room. Accept your fate and exit the program.");
                Console.Write("Option: ");
                int choice = int.Parse(Console.ReadLine());

                //Alternativ i menyn

                switch (choice)
                {
                    case 1:
                        WorldHelper.StartGame(player);
                        break;
                    case 2:
                        if (player is Warrior wRest)
                        {
                            WorldHelper.Rest(wRest);
                        }
                        else if (player is Mage mRest)
                        {
                            WorldHelper.Rest(mRest);
                        }
                        break;
                    case 3:
                        if (player is Warrior wStatus)
                        {
                            wStatus.PrintStatusW();
                        }
                        else if (player is Mage mStatus)
                        {
                            mStatus.PrintStatusM();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting program.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            }


        }
    }
}
