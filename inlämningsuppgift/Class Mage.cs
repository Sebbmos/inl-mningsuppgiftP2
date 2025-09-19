namespace inlämningsuppgift
{
    public class Mage
    {

        public string Name;
        public int HP;
        public int MaxHP;
        public int Damage;
        public int Gold;


        public Mage(string name, int hp, int damage, int gold)
        {
            Name = name;
            HP = hp;
            MaxHP = hp;
            Damage = damage;
            Gold = gold;




        }
        //Status för mage
        public void PrintStatusM()
        {

            Console.WriteLine($"{Name} the Mage. You have {HP}/{MaxHP} HP, {Damage} damage, {Gold} gold.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }

    }
}
