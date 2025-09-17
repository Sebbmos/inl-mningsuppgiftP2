

namespace inlämningsuppgift
{
    public class EnemiesCreator
    {


        public string Name;
        public int Hp;
        public string Damage;
        public int GoldReward;




        public string[] enemies = { "evilRat", "Guard", "Thug", "Skeleton", "The Jailor", "JavaJack" };

        public EnemiesCreator(string name, int hp, string damage, int goldReward, string[] enemies)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
            GoldReward = goldReward;
            this.enemies = enemies;
        }
    }
}
