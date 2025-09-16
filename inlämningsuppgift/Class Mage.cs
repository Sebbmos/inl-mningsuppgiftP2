namespace inlämningsuppgift
{
    public class Mage
    {
        public int Mana;
        public string Name;
        public int Hp;
        public int Damage;
        public int Gold;


        public Mage(string name, int hp, int damage, int gold, int mana)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
            Gold = gold;
            Mana = mana;

            Console.WriteLine($"{Name} the Mage has {Hp} HP, {Damage} damage, {Gold} gold and {Mana} MP.");

        }

    }
}
