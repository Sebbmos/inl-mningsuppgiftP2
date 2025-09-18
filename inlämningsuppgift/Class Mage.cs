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



        }
        public void PrintStatusM()   // test
        {

            Console.WriteLine($" Greetings {Name} the Mage. You have {Hp} HP, {Damage} damage, {Gold} gold and {Mana} MP.");
        }

    }
}
