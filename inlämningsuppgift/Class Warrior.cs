

namespace inlämningsuppgift
{
    public class Warrior
    {
        public string Name;
        public int Hp;
        public int Damage;
        public int Gold;


        public Warrior(string name, int hp, int damage, int gold)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
            Gold = gold;
        }

        public void PrintStatusW()  //test
        {
            Console.WriteLine($"Greetings {Name} the warrior. You have {Hp} HP, {Damage} damage, {Gold} gold.");
        }


    }

}
