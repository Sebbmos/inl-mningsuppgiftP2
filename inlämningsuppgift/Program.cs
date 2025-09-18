namespace inlämningsuppgift
{
    public class Program
    {


        static void Main(string[] args)
        { //starta karaktär och välja klass

            string classChoice;
            string playername;

            Console.WriteLine("Welcome, State your name");
            playername = Console.ReadLine().ToLower();

            Console.WriteLine($"{playername} what is your school of war? Warrior or Mage?");
            classChoice = Console.ReadLine().ToLower();


            if (classChoice == "warrior")
            {
                Warrior player = Character_Creation.CreateWarrior(playername);
                player.PrintStatusW();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

            }
            else if (classChoice == "mage")
            {
                Mage player = Character_Creation.CreateMage(playername);
                player.PrintStatusM();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid choice. You will be defaulted to warrior.");
                Warrior player = Character_Creation.CreateWarrior(playername);
                player.PrintStatusW();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }



            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("----- DUNGEON ESCAPE ------");
                Console.WriteLine("[1] Fight for your freedom.");
                Console.WriteLine("[2] Rest for a bit. While you can.");
                Console.WriteLine("[3] Show status.");
                Console.WriteLine("[4] Accept your fate and exit the program.");
                Console.Write("Option: ");
                int choice = int.Parse(Console.ReadLine());

                //Alternativ i menyn

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Starta äventyret/fortsätta");
                        break;
                    case 2:
                        Console.WriteLine("Vila och återhämta hp");
                        break;
                    case 3:
                        Console.WriteLine("Visa hp/mana/guld");
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
