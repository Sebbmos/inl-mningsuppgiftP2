namespace inlämningsuppgift
{
    public class Program
    {


        static void Main(string[] args)
        {
            string playername = "";
            Console.WriteLine("Write your name");
            playername = Console.ReadLine();
            Warrior warrior = new Warrior(playername, 200, 30, 0);
            //Kolla att du kan skapa en mageklass också.
            warrior.Printstatus();



        }
    }
}
