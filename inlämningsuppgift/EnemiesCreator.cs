

using System.Security.Cryptography.X509Certificates;

namespace inlämningsuppgift
{
    public class EnemiesCreator
    {


        public string Name;
        public int Hp;
        public string Damage;
        public int GoldReward;




        public string[] Enemies = { "evilRat", "Guard", "Thug", "Skeleton", "The Jailor", "JavaJack" };

        public EnemiesCreator(string name, int hp, string damage, int goldReward, string[] enemies)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
            GoldReward = goldReward;
            Enemies = enemies;

           

        }
        public Enemy()
        {
            Random rndm = new Random();

            int next = rndm.Next(EnemiesCreator)

                EnemyName = Enemies[i];


            switch (Enemies)
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
                case "The jailor":
                    Hp = 100;
                    Damage = 34;
                    GoldReward = 100;
                    break;
                case "JavaJack":
                    Hp = 1;
                    Damage = 0;
                    Goldreward = 100;



            }

        }
         

    }
}
