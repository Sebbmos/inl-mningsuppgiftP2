

namespace inlämningsuppgift
{
    public class Warrior
    {
        public string Name;
        public int HP;
        public int MaxHP;
        public int Damage;
        public int Gold;


        public Warrior(string name, int hp, int damage, int gold)
        {
            Name = name;
            HP = hp;
            MaxHP = hp;
            Damage = damage;
            Gold = gold;
        }
        // Status för warrior

        public void PrintStatusW()
        {
            Console.WriteLine($"{Name} the warrior. You have {HP}/{MaxHP} HP, {Damage} damage, {Gold} gold.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }


    }

}
