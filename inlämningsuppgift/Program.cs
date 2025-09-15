namespace inlämningsuppgift
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string playername = "";
            Console.WriteLine("Write your name");
            playername = Console.ReadLine();
            Class_Warrior player = new Class_Warrior(playername);


        }
    }
}
