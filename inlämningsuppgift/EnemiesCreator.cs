namespace inlämningsuppgift
{
    public class EnemiesCreator
    {


        public string Name;
        public int Hp;
        public int Damage;
        public int GoldReward;




        public string[] Enemies = { "EvilRat", "Guard", "Thug", "Skeleton", "The Jailor", "JavaJack" };

        public EnemiesCreator(string name, int hp, int damage, int goldReward, string[] enemies)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
            GoldReward = goldReward;
            Enemies = enemies;



        }
        public EnemiesCreator()
        {
            Random rndm = new Random();

            int next = rndm.Next(Enemies.Length);

            Name = Enemies[next];


            switch (Name)
            {

                case "EvilRat":
                    Hp = 10;
                    Damage = 8;
                    GoldReward = 0;
                    break;

                case "Guard":
                    Hp = 50;
                    Damage = 25;
                    GoldReward = 20;
                    break;
                case "Thug":
                    Hp = 65;
                    Damage = 17;
                    GoldReward = 16;
                    break;
                case "Skeleton":
                    Hp = 70;
                    Damage = 23;
                    GoldReward = 23;
                    break;
                case "The Jailor":
                    Hp = 100;
                    Damage = 34;
                    GoldReward = 100;
                    break;
                case "JavaJack":
                    Hp = 1;
                    Damage = 0;
                    GoldReward = 100;
                    break;


            }

        }


    }
}
