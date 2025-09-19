namespace inlämningsuppgift
{
    public class EnemiesCreator
    {


        public string EnemyName;
        public int EnemyHp;
        public int EnemyDamage;
        public int GoldReward;



        //fiender                                                                         Jack räknas som en loot goblin
        public string[] Enemies = { "EvilRat", "Guard", "Thug", "Skeleton", "The Jailor", "JavaJack" };


        public EnemiesCreator()
        {
            Random rndm = new Random();

            int next = rndm.Next(Enemies.Length);

            EnemyName = Enemies[next];

            //enemy skapare

            switch (EnemyName)
            {

                case "EvilRat":
                    Console.WriteLine("SQUEEEK!\n");
                    EnemyHp = 10;
                    EnemyDamage = 8;
                    GoldReward = 0;
                    break;

                case "Guard":
                    Console.WriteLine("When did you wake up? Cmere or i'll cut you down!\n");
                    EnemyHp = 50;
                    EnemyDamage = 25;
                    GoldReward = 20;
                    break;
                case "Thug":
                    Console.WriteLine("I tought I would find some gold here.. I'll just have to loot your corpse.\n");
                    EnemyHp = 65;
                    EnemyDamage = 17;
                    GoldReward = 16;
                    break;
                case "Skeleton":
                    Console.WriteLine("you look at the lifeless skeleton. it doesn't speak but you know it will try to kill you.\n");
                    EnemyHp = 70;
                    EnemyDamage = 23;
                    GoldReward = 23;
                    break;
                case "The Jailor":
                    Console.WriteLine("Ah. I see you are awake, I have plans for you so either you stay here living or dead.\n");
                    EnemyHp = 100;
                    EnemyDamage = 34;
                    GoldReward = 100;
                    break;
                case "JavaJack":
                    Console.WriteLine("Please.. I've been here for so many years. Please just end it I cannot take it anymore.\n");
                    EnemyHp = 1;
                    EnemyDamage = 0;
                    GoldReward = 100;
                    break;


            }

        }


    }
}
